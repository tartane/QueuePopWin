using QueuePopDesktop.CustomControls;

namespace QueuePopDesktop
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            notifyIconApp = new NotifyIcon(components);
            menuStripNotifyIcon = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            startToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            menuItemExit = new ToolStripMenuItem();
            btnStart = new BaseButton();
            cbDevices = new ComboBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            linkNotificationDeviceToolStripMenuItem = new ToolStripMenuItem();
            checkForUpdateToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            reportIssueToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            btnQrCode = new Button();
            toolTipAudioOutput = new ToolTip(components);
            label2 = new Label();
            timerNotif = new System.Windows.Forms.Timer(components);
            btnStop = new BaseButton();
            lstGames = new ListBox();
            txtFilter = new TextBox();
            linkRequestGame = new LinkLabel();
            menuStripNotifyIcon.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIconApp
            // 
            notifyIconApp.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconApp.BalloonTipText = "QueuePop running...";
            notifyIconApp.BalloonTipTitle = "QueuePop";
            notifyIconApp.ContextMenuStrip = menuStripNotifyIcon;
            notifyIconApp.Icon = (Icon)resources.GetObject("notifyIconApp.Icon");
            notifyIconApp.Text = "QueuePop running...";
            notifyIconApp.Visible = true;
            notifyIconApp.MouseDoubleClick += notifyIconApp_MouseDoubleClick;
            // 
            // menuStripNotifyIcon
            // 
            menuStripNotifyIcon.ImageScalingSize = new Size(20, 20);
            menuStripNotifyIcon.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, startToolStripMenuItem, stopToolStripMenuItem, menuItemExit });
            menuStripNotifyIcon.Name = "contextMenuStrip1";
            menuStripNotifyIcon.Size = new Size(115, 100);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(114, 24);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(114, 24);
            startToolStripMenuItem.Text = "Start";
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(114, 24);
            stopToolStripMenuItem.Text = "Stop";
            stopToolStripMenuItem.Visible = false;
            stopToolStripMenuItem.Click += stopToolStripMenuItem_Click;
            // 
            // menuItemExit
            // 
            menuItemExit.Name = "menuItemExit";
            menuItemExit.Size = new Size(114, 24);
            menuItemExit.Text = "Exit";
            menuItemExit.Click += menuItemExit_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(100, 102, 110);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(297, 362);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(108, 46);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // cbDevices
            // 
            cbDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDevices.FormattingEnabled = true;
            cbDevices.Location = new Point(12, 68);
            cbDevices.Margin = new Padding(3, 4, 3, 4);
            cbDevices.Name = "cbDevices";
            cbDevices.Size = new Size(393, 28);
            cbDevices.TabIndex = 1;
            toolTipAudioOutput.SetToolTip(cbDevices, "Queue Pop will listen to this audio output for any queue sounds.");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 3;
            label1.Text = "Audio output";
            toolTipAudioOutput.SetToolTip(label1, "Queue Pop will listen to this audio output for any queue sounds.\r\n");
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(417, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { linkNotificationDeviceToolStripMenuItem, checkForUpdateToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // linkNotificationDeviceToolStripMenuItem
            // 
            linkNotificationDeviceToolStripMenuItem.Name = "linkNotificationDeviceToolStripMenuItem";
            linkNotificationDeviceToolStripMenuItem.Size = new Size(245, 26);
            linkNotificationDeviceToolStripMenuItem.Text = "Link notification device";
            linkNotificationDeviceToolStripMenuItem.Click += linkNotificationDeviceToolStripMenuItem_Click;
            // 
            // checkForUpdateToolStripMenuItem
            // 
            checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            checkForUpdateToolStripMenuItem.Size = new Size(245, 26);
            checkForUpdateToolStripMenuItem.Text = "Check for update";
            checkForUpdateToolStripMenuItem.Click += checkForUpdateToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(245, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportIssueToolStripMenuItem1, aboutToolStripMenuItem1 });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // reportIssueToolStripMenuItem1
            // 
            reportIssueToolStripMenuItem1.Name = "reportIssueToolStripMenuItem1";
            reportIssueToolStripMenuItem1.Size = new Size(173, 26);
            reportIssueToolStripMenuItem1.Text = "Report issue";
            reportIssueToolStripMenuItem1.Click += reportIssueToolStripMenuItem1_Click;
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(173, 26);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(0, 422);
            statusStrip.Name = "statusStrip";
            statusStrip.RenderMode = ToolStripRenderMode.Professional;
            statusStrip.Size = new Size(417, 26);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(101, 20);
            lblStatus.Text = "Ready to start";
            // 
            // btnQrCode
            // 
            btnQrCode.BackgroundImage = Properties.Resources.qr_code_white;
            btnQrCode.BackgroundImageLayout = ImageLayout.Zoom;
            btnQrCode.FlatAppearance.BorderColor = Color.Gray;
            btnQrCode.FlatAppearance.BorderSize = 0;
            btnQrCode.FlatStyle = FlatStyle.Flat;
            btnQrCode.Location = new Point(12, 368);
            btnQrCode.Name = "btnQrCode";
            btnQrCode.Size = new Size(40, 40);
            btnQrCode.TabIndex = 7;
            btnQrCode.UseVisualStyleBackColor = false;
            btnQrCode.Click += btnQrCode_Click;
            // 
            // toolTipAudioOutput
            // 
            toolTipAudioOutput.IsBalloon = true;
            toolTipAudioOutput.ShowAlways = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 9;
            label2.Text = "Supported game list";
            toolTipAudioOutput.SetToolTip(label2, "Queue Pop will listen to this audio output for any queue sounds.\r\n");
            // 
            // timerNotif
            // 
            timerNotif.Interval = 10000;
            timerNotif.Tick += timerNotif_Tick;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(100, 102, 110);
            btnStop.Enabled = false;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(166, 362);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(108, 46);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // lstGames
            // 
            lstGames.FormattingEnabled = true;
            lstGames.ItemHeight = 20;
            lstGames.Location = new Point(12, 141);
            lstGames.Name = "lstGames";
            lstGames.Size = new Size(393, 184);
            lstGames.TabIndex = 10;
            lstGames.MouseDoubleClick += lstGames_MouseDoubleClickAsync;
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFilter.Location = new Point(280, 112);
            txtFilter.MinimumSize = new Size(125, 10);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "Filter";
            txtFilter.Size = new Size(125, 25);
            txtFilter.TabIndex = 11;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // linkRequestGame
            // 
            linkRequestGame.AutoSize = true;
            linkRequestGame.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            linkRequestGame.ForeColor = Color.White;
            linkRequestGame.LinkColor = Color.White;
            linkRequestGame.Location = new Point(10, 325);
            linkRequestGame.Name = "linkRequestGame";
            linkRequestGame.Size = new Size(144, 19);
            linkRequestGame.TabIndex = 12;
            linkRequestGame.TabStop = true;
            linkRequestGame.Text = "Can't find your game?";
            linkRequestGame.LinkClicked += linkRequestGame_LinkClicked;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 51, 56);
            ClientSize = new Size(417, 448);
            Controls.Add(linkRequestGame);
            Controls.Add(txtFilter);
            Controls.Add(lstGames);
            Controls.Add(btnStop);
            Controls.Add(label2);
            Controls.Add(btnQrCode);
            Controls.Add(statusStrip);
            Controls.Add(label1);
            Controls.Add(cbDevices);
            Controls.Add(btnStart);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Queue Pop";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            Resize += Main_Resize;
            menuStripNotifyIcon.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIconApp;
        private ComboBox cbDevices;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem linkNotificationDeviceToolStripMenuItem;
        private Button btnQrCode;
        private ToolTip toolTipAudioOutput;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem reportIssueToolStripMenuItem1;
        private Label label2;
        private System.Windows.Forms.Timer timerNotif;
        private CustomControls.BaseButton btnStop;
        private ContextMenuStrip menuStripNotifyIcon;
        private ToolStripMenuItem menuItemExit;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private BaseButton btnStart;
        private ListBox lstGames;
        private TextBox txtFilter;
        private LinkLabel linkRequestGame;
    }
}

