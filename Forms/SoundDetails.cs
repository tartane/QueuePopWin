using Shared.Supabase.Models;

namespace QueuePopDesktop
{
    public partial class SoundDetails : BaseForm
    {
        private List<SoundFile> soundFiles;
        private string gameTitle;

        public SoundDetails(string gameTitle, List<SoundFile> soundFiles)
        {
            this.soundFiles = soundFiles;
            this.gameTitle = gameTitle;
            InitializeComponent();
        }

        private void SoundDetails_Load(object sender, EventArgs e)
        {
            lblGameTitle.Text += " " + gameTitle;

            foreach (SoundFile file in soundFiles)
            {
                lstSoundFiles.Items.Add(new ListViewItem(new[] { file.SoundTitle, file.Description }));
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
