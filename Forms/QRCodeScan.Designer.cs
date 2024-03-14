using QueuePopDesktop.CustomControls;

namespace QueuePopDesktop
{
    partial class QRCodeScan
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
            picBoxQRCode = new PictureBox();
            label1 = new Label();
            lblLinkManually = new LinkLabel();
            btnDone = new BaseButton();
            btnRefresh = new BaseButton();
            linkLblPlayStore = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            btnQrCode = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxQRCode).BeginInit();
            SuspendLayout();
            // 
            // picBoxQRCode
            // 
            picBoxQRCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picBoxQRCode.Location = new Point(175, 211);
            picBoxQRCode.Margin = new Padding(3, 4, 3, 4);
            picBoxQRCode.Name = "picBoxQRCode";
            picBoxQRCode.Size = new Size(250, 250);
            picBoxQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxQRCode.TabIndex = 4;
            picBoxQRCode.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 29);
            label1.Name = "label1";
            label1.Size = new Size(374, 46);
            label1.TabIndex = 5;
            label1.Text = "Notification Device Link";
            // 
            // lblLinkManually
            // 
            lblLinkManually.AutoSize = true;
            lblLinkManually.LinkColor = Color.White;
            lblLinkManually.Location = new Point(175, 465);
            lblLinkManually.Name = "lblLinkManually";
            lblLinkManually.Size = new Size(212, 20);
            lblLinkManually.TabIndex = 6;
            lblLinkManually.TabStop = true;
            lblLinkManually.Text = "Unable to scan? Link manually ";
            lblLinkManually.LinkClicked += lblLinkManually_LinkClicked;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(100, 102, 110);
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDone.ForeColor = Color.White;
            btnDone.Location = new Point(482, 510);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(108, 46);
            btnDone.TabIndex = 7;
            btnDone.Text = "OK";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(100, 102, 110);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(368, 510);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(108, 46);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // linkLblPlayStore
            // 
            linkLblPlayStore.AutoSize = true;
            linkLblPlayStore.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLblPlayStore.ForeColor = Color.White;
            linkLblPlayStore.LinkColor = Color.White;
            linkLblPlayStore.Location = new Point(53, 540);
            linkLblPlayStore.Name = "linkLblPlayStore";
            linkLblPlayStore.Size = new Size(204, 19);
            linkLblPlayStore.TabIndex = 11;
            linkLblPlayStore.TabStop = true;
            linkLblPlayStore.Text = "Download on Google Play Store";
            linkLblPlayStore.TextAlign = ContentAlignment.MiddleCenter;
            linkLblPlayStore.LinkClicked += linkLblPlayStore_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(53, 520);
            label2.Name = "label2";
            label2.Size = new Size(184, 19);
            label2.TabIndex = 12;
            label2.Text = "Don't have the android app?";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 99);
            label3.Name = "label3";
            label3.Size = new Size(462, 108);
            label3.TabIndex = 13;
            label3.Text = "Open the Android app and follow the instructions.\r\n\r\nYou will need to link your desktop with your mobile device by scanning the QR code.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnQrCode
            // 
            btnQrCode.BackgroundImage = Properties.Resources.qr_code_white;
            btnQrCode.BackgroundImageLayout = ImageLayout.Zoom;
            btnQrCode.FlatAppearance.BorderColor = Color.Gray;
            btnQrCode.FlatAppearance.BorderSize = 0;
            btnQrCode.FlatStyle = FlatStyle.Flat;
            btnQrCode.Location = new Point(18, 525);
            btnQrCode.Name = "btnQrCode";
            btnQrCode.Size = new Size(30, 30);
            btnQrCode.TabIndex = 14;
            btnQrCode.UseVisualStyleBackColor = false;
            btnQrCode.Click += btnQrCode_Click;
            // 
            // QRCodeScan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 51, 56);
            ClientSize = new Size(602, 573);
            Controls.Add(btnQrCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLblPlayStore);
            Controls.Add(btnRefresh);
            Controls.Add(btnDone);
            Controls.Add(lblLinkManually);
            Controls.Add(label1);
            Controls.Add(picBoxQRCode);
            Name = "QRCodeScan";
            Padding = new Padding(20);
            Text = "QR Code";
            ((System.ComponentModel.ISupportInitialize)picBoxQRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxQRCode;
        private Label label1;
        private LinkLabel lblLinkManually;
        private BaseButton btnDone;
        private BaseButton btnRefresh;
        private LinkLabel linkLblPlayStore;
        private Label label2;
        private Label label3;
        private Button btnQrCode;
    }
}