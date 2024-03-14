
using NAudio.CoreAudioApi;
using NAudio.Wave;
using SoundFingerprinting.Builder;
using SoundFingerprinting.Data;
using SoundFingerprinting.InMemory;
using System.Diagnostics;
using QueuePopDesktop.Properties;
using Shared.Supabase.Models;
using AudioFingerprintSupabase;
using ProtoBuf;
using SoundFingerprinting.Audio;
using System.Collections.Concurrent;
using SoundFingerprinting.Command;
using SoundFingerprinting;
using WaveFormat = NAudio.Wave.WaveFormat;
using QueuePopDesktop.Models;

namespace QueuePopDesktop
{
    public partial class Main : Form
    {

        private static double RECORDING_LENGTH = 2.5;

        private IWaveIn captureDevice;
        private WaveFileWriter writer;
        private int outputCount = 1;
        private InMemoryModelService modelService;
        private Queue<string> recordedAudioSamples;
        private List<Game> supportedGameList = new List<Game>();
        private AppStatus currentAppStatus = AppStatus.READY;

        public Main()
        {
            InitializeComponent();
        }

        void cleanUpRecordingsDirectory()
        {
            var directory = Path.Combine(getOutputDirectory(), "Recordings");
            if (Directory.Exists(directory))
            {
                Directory.GetFiles(directory).ToList().ForEach(f => File.Delete(f));
            }
        }

        private async Task deleteExpiredFingerprints() {

            var dataDirectory = getAudioFingerprintsDirectoryPath();

            var filePaths = Directory.GetFiles(dataDirectory, "*.dat", SearchOption.TopDirectoryOnly);

            try
            {
                //Delete local sound files that have been deleted from supabase.
                var deletedSoundFileTable = SupabaseClient.Instance.From<DeletedSoundFile>();
                var deletedSounds = await deletedSoundFileTable.Get();

                foreach (var path in filePaths)
                {
                    var localFilename = Path.GetFileName(path);

                    for (int i = 0; i < deletedSounds.Models.Count; i++)
                    {
                        var m = deletedSounds.Models[i];
                        var deletedRemoteFullFilename = m.Filename + "_" + m.Id + ".dat";

                        if (localFilename == deletedRemoteFullFilename)
                        {
                            File.Delete(path);
                        }
                    }

                }
            }
            catch
            {
                //Swallow everything, it doesn't matter if sounds are not deleted.
            }
        }

        private async Task loadFingerprintsAsync()
        {
            setAppStatus(AppStatus.LOADING_FINGERPRINTS);

            //Check if our data directory exists, if not, the app might have been uninstalled. We will need a full refetch
            var dataDirectory = getAudioFingerprintsDirectoryPath();
            if (!Directory.Exists(dataDirectory))
            {
                Settings.Default.sound_data_update_date = DateTime.MinValue;
                Settings.Default.Save();

                Directory.CreateDirectory(dataDirectory);
            }

            using (LoadingDialog loadingDialog = new LoadingDialog("Looking for new audio data..."))
            {
                BeginInvoke(() => loadingDialog.ShowDialog());

                var soundFileTable = SupabaseClient.Instance.From<SoundFile>();

                var lastFetchDate = Settings.Default.sound_data_update_date;

                var allSounds = await soundFileTable.Get();
                var filteredModels = allSounds.Models.Where(m => m.UpdatedAt > lastFetchDate && m.DownloadUrl != null).ToList();
                if (filteredModels.Count > 0)
                {
                    loadingDialog.setMaxValue(filteredModels.Count);

                    using (var client = new HttpClient())
                    {
                        for (int i = 0; i < filteredModels.Count; i++)
                        {
                            var m = filteredModels[i];
                            using (var s = client.GetStreamAsync(m.DownloadUrl))
                            {
                                using (var fs = new FileStream(Path.Combine(dataDirectory, m.Filename + "_" + m.Id + ".dat"), FileMode.OpenOrCreate))
                                {
                                    s.Result.CopyTo(fs);
                                }
                            }
                            loadingDialog.updateText($"Downloading new audio data. {i + 1}/{filteredModels.Count} completed.");
                            loadingDialog.setProgress(i + 1);

                        }
                    }

                    Settings.Default.sound_data_update_date = DateTime.Now;
                    Settings.Default.Save();
                }


                await deleteExpiredFingerprints();

                var filePaths = Directory.GetFiles(dataDirectory, "*.dat", SearchOption.TopDirectoryOnly);
                loadingDialog.setMaxValue(filePaths.Length);
                loadingDialog.setProgress(0);
                loadingDialog.updateText($"Loading sound fingerprints in memory. 0/{filePaths.Length} completed.");

                for (int i = 0; i < filePaths.Length; i++)
                {
                    var path = filePaths[i];
                    (TrackInfo trackInfo, AVHashes avHashes) audioData;
                    using (var file = File.OpenRead(path))
                    {
                        audioData = Serializer.Deserialize<(TrackInfo trackInfo, AVHashes avHashes)>(file);

                        modelService.Insert(audioData.trackInfo, audioData.avHashes);
                    }
                    loadingDialog.updateText($"Loading sound fingerprints in memory. {i + 1}/{filePaths.Length} completed.");
                    loadingDialog.setProgress(i + 1);
                }
            }

            setAppStatus(AppStatus.READY);
        }


        async void checkForMatch()
        {

            var fileName = recordedAudioSamples.Dequeue();


            var queryResult = await QueryCommandBuilder.Instance
                                             .BuildQueryCommand()
                                             .From(fileName)
                                             .WithQueryConfig(config =>
                                             {
                                                 config.Audio.PermittedGap = 3d;
                                                 config.Audio.ThresholdVotes = 4;//lower for more match. At 1, it seems to be matching random sounds.
                                                 config.Audio.Stride = new SoundFingerprinting.Strides.IncrementalStaticStride(64); //lower for more match (not been able to go lower than 64)

                                                 return config;
                                             })
                                             .UsingServices(modelService)
                                             .Query();

            foreach (var (entry, _) in queryResult.ResultEntries)
            {
                //timer to prevent sending notifiation twice for the same sound (resets every 10 seconds)
                if (!timerNotif.Enabled)
                {
                    timerNotif.Enabled = true;
                    var gameTitle = entry.Track.Artist;
                    var message = entry.Track.Title;

                    LocalNotification
                        .create($"Queue pop for {gameTitle}", message)
                        .send();

                    await QueuePopService.SendNotificationAsync(Settings.Default.guid.ToString(), gameTitle, message);
                }

            }

            File.Delete(fileName);
        }

        private void notifyIconApp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openAppFromTray();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIconApp.Visible = true;
                notifyIconApp.ShowBalloonTip(3000);
                ShowInTaskbar = false;
            }
        }

        private void openAppFromTray()
        {

            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            notifyIconApp.Visible = false;
            Show();
        }

        private void cleanUp()
        {
            if (captureDevice != null)
            {
                captureDevice.DataAvailable -= OnDataAvailable;
                captureDevice.RecordingStopped -= OnRecordingStopped;
                captureDevice.Dispose();
                captureDevice = null;
            }
        }

        void StopRecording()
        {
            captureDevice?.StopRecording();
        }

        void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<WaveInEventArgs>(OnDataAvailable), sender, e);
            }
            else
            {
                writer.Write(e.Buffer, 0, e.BytesRecorded);

                double secondsRecorded = Convert.ToDouble(writer.Length) / writer.WaveFormat.AverageBytesPerSecond;
                if (secondsRecorded >= RECORDING_LENGTH)
                {
                    completeWriteFile();
                }
            }
        }

        public static async Task<double> GetBestMatchForStream(BlockingCollection<AudioSamples> audioSamples, IModelService modelService, CancellationToken token)
        {
            double seconds = await QueryCommandBuilder.Instance
                .BuildRealtimeQueryCommand()
                .From(new BlockingRealtimeCollection<AudioSamples>(audioSamples))
                .WithRealtimeQueryConfig(config =>
                {
                    // match only those entries got at least 5 seconds of query match
                    config.ResultEntryFilter = new TrackMatchLengthEntryFilter(5d);

                    // provide a success callback that will be invoked for matches that pass the result entry filter
                    config.SuccessCallback = result =>
                    {
                        foreach (var entry in result.ResultEntries)
                        {
                            Console.WriteLine($"Successfully matched {entry.TrackId}");
                        }
                    };

                    config.DidNotPassFilterCallback = (queryResult) =>
                    {
                        foreach (var result in queryResult.ResultEntries)
                        {
                            Console.WriteLine($"Did not pass filter {result.TrackId}");
                        }
                    };

                    return config;
                })
                .UsingServices(modelService)
                .Query(token);

            Console.WriteLine($"Realtime query stopped. Issued {seconds} seconds of query.");
            return seconds;
        }

        string getOutputDirectory()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\QueuePop";
        }

        string getAudioSamplePath()
        {
            var directory = Path.Combine(getOutputDirectory(), "Recordings");
            var fileName = Path.Combine(directory, $@"output{outputCount}.wav");
            Directory.CreateDirectory(directory);
            return fileName;
        }

        string getAudioFingerprintsDirectoryPath()
        {
            return Path.Combine(getOutputDirectory(), "Data");
        }

        void completeWriteFile()
        {
            var fileName = writer.Filename;

            recordedAudioSamples.Enqueue(fileName);

            writer?.Dispose();
            writer = null;

            checkForMatch();

            outputCount++;
            initWriter();
        }

        void initWriter()
        {
            writer = new WaveFileWriter(getAudioSamplePath(), captureDevice.WaveFormat);
        }

        void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<StoppedEventArgs>(OnRecordingStopped), sender, e);
            }
            else
            {
                FinalizeWaveFile();
            }
        }

        private void FinalizeWaveFile()
        {
            writer?.Dispose();
            writer = null;
        }

        private void start()
        {
            stopToolStripMenuItem.Visible = true;
            startToolStripMenuItem.Visible = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;


            cleanUpRecordingsDirectory();

            var selectedDevice = cbDevices.SelectedItem as MMDevice;
            selectedDevice.AudioEndpointVolume.Mute = false;

            captureDevice = new WasapiLoopbackCapture(selectedDevice);
            var sampleRate = 44100; //8000 16000 22050 32000 44100 48000
            var channels = 2; //1 mono, 2 stereo
            captureDevice.WaveFormat = new WaveFormat(sampleRate, channels);
            initWriter();
            captureDevice.DataAvailable += OnDataAvailable;
            captureDevice.RecordingStopped += OnRecordingStopped;
            captureDevice.StartRecording();

            LocalNotification
                .create("Queue pop", "Now listening to queue sounds!")
                .send();

            setAppStatus(AppStatus.LISTENING);
        }

        private void stop()
        {
            stopToolStripMenuItem.Visible = false;
            startToolStripMenuItem.Visible = true;
            btnStop.Enabled = false;
            btnStart.Enabled = true;

            StopRecording();

            setAppStatus(AppStatus.READY);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start();
        }

        private void setAppStatus(AppStatus status)
        {
            currentAppStatus = status;
            lblStatus.Text = status.ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop();
        }

        private bool checkIfAppAlreadyRunning()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("QueuePop is already running.", "QueuePop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
                return true;
            }

            return false;
        }

        async private void Main_Load(object sender, EventArgs e)
        {
            if (checkIfAppAlreadyRunning())
                return;

            //Look for previous version settings
            if (Settings.Default.call_upgrade)
            {
                Settings.Default.Upgrade();
                Settings.Default.call_upgrade = false;
                Settings.Default.Save();
            }

            if (Settings.Default.is_first_run)
            {
                new QRCodeScan().ShowDialog();
                Settings.Default.is_first_run = false;
                Settings.Default.Save();
            }

            recordedAudioSamples = new Queue<string>();
            modelService = new InMemoryModelService();

            cleanUpRecordingsDirectory();

            await Task.WhenAll(loadFingerprintsAsync(), initGameListAsync());
            loadAudioEndpoints();
            checkForUpdate(false);
        }

        private async Task initGameListAsync()
        {
            var gameTable = SupabaseClient.Instance.From<Game>();
            var result = await gameTable.Select("id, game_title, sound_file!inner(file_name)").Get();
            supportedGameList = result.Models.OrderBy(g => g.GameTitle).ToList();
            lstGames.DataSource = supportedGameList;
        }

        private void loadAudioEndpoints()
        {
            var enumerator = new MMDeviceEnumerator();
            var defaultAudioEndpoint = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            foreach (var audioEndpoint in enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active))
            {
                cbDevices.Items.Add(audioEndpoint);

                if (defaultAudioEndpoint != null &&
                    audioEndpoint.ID == defaultAudioEndpoint.ID)
                {
                    cbDevices.SelectedItem = audioEndpoint;
                }

                Console.WriteLine($"{audioEndpoint.DataFlow} {audioEndpoint.FriendlyName} {audioEndpoint.DeviceFriendlyName} {audioEndpoint.State}");

            }
        }

        private async void checkForUpdate(bool isManualUpdate)
        {
            (QueuePopService.ECheckForUpdateStatus status, float newVersion) response;
            if (isManualUpdate)
            {
                setAppStatus(AppStatus.CHECKING_UPDATE);
                using (new AppWaitCursor())
                {
                    response = await QueuePopService.CheckForUpdate();
                }
            }
            else
            {
                response = await QueuePopService.CheckForUpdate();
            }

            if (response.status == QueuePopService.ECheckForUpdateStatus.SHOULD_UPDATE)
            {
                if (isManualUpdate || Settings.Default.dont_ask_for_update_version != response.newVersion)
                {
                    new AskForUpdate(response.newVersion, isManualUpdate).ShowDialog();
                }
            }
            else
            {

                if (isManualUpdate)
                {
                    if (response.status == QueuePopService.ECheckForUpdateStatus.UP_TO_DATE)
                    {
                        MessageBox.Show("QueuePop is up to date.", "Latest version", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (response.status == QueuePopService.ECheckForUpdateStatus.ERROR)
                    {
                        MessageBox.Show("Check for update failed. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            //just in case the user quickly presses start
            if (currentAppStatus.Value != AppStatus.LISTENING.Value)
            {
                setAppStatus(AppStatus.READY);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkNotificationDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QRCodeScan().ShowDialog();
        }

        private void btnQrCode_Click(object sender, EventArgs e)
        {
            new QRCodeScan().ShowDialog();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void reportIssueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ReportIssue().ShowDialog();
        }

        private async void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkForUpdate(true);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopRecording();
        }

        private void timerNotif_Tick(object sender, EventArgs e)
        {
            timerNotif.Enabled = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAppFromTray();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            lstGames.DataSource = supportedGameList.FindAll(g => g.GameTitle.ToLower().Contains(txtFilter.Text.ToLower()));
        }

        private void linkRequestGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://www.qpop.gg/requestgame");
            }
            catch
            {
                Process.Start(new ProcessStartInfo("https://www.qpop.gg/requestgame") { UseShellExecute = true });
            }
        }

        private async void lstGames_MouseDoubleClickAsync(object sender, MouseEventArgs e)
        {
            if (lstGames.SelectedItem != null) {
                var game = (Game) lstGames.SelectedItem;

                var soundFileTable = SupabaseClient.Instance.From<SoundFile>();
                var result = await soundFileTable.Where(s => s.GameId == game.Id).Get();

                new SoundDetails(game.GameTitle, result.Models).ShowDialog();
            }
        }
    }
}
