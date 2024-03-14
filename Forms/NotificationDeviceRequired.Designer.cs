using QueuePopDesktop.CustomControls;

namespace QueuePopDesktop
{
    partial class NotificationDeviceRequired
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
            label2 = new Label();
            label1 = new Label();
            linkLblPlayStore = new LinkLabel();
            btnNext = new BaseButton();
            picBoxQRCode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxQRCode).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 80);
            label2.Name = "label2";
            label2.Size = new Size(462, 108);
            label2.TabIndex = 8;
            label2.Text = "QueuePop requires the android app on your mobile device to send you notifications.\r\n\r\nScan the QR code to download the Android app.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(343, 46);
            label1.TabIndex = 6;
            label1.Text = "Android app required";
            label1.Click += label1_Click;
            // 
            // linkLblPlayStore
            // 
            linkLblPlayStore.AutoSize = true;
            linkLblPlayStore.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLblPlayStore.ForeColor = Color.White;
            linkLblPlayStore.LinkColor = Color.White;
            linkLblPlayStore.Location = new Point(162, 408);
            linkLblPlayStore.Name = "linkLblPlayStore";
            linkLblPlayStore.Size = new Size(204, 38);
            linkLblPlayStore.TabIndex = 10;
            linkLblPlayStore.TabStop = true;
            linkLblPlayStore.Text = "Unable to scan?\r\nDownload on Google Play Store";
            linkLblPlayStore.LinkClicked += linkLblPlayStore_LinkClicked;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(100, 102, 110);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(421, 424);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(108, 46);
            btnNext.TabIndex = 11;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // picBoxQRCode
            // 
            picBoxQRCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picBoxQRCode.Location = new Point(162, 194);
            picBoxQRCode.Margin = new Padding(3, 4, 3, 4);
            picBoxQRCode.Name = "picBoxQRCode";
            picBoxQRCode.Size = new Size(220, 210);
            picBoxQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxQRCode.TabIndex = 12;
            picBoxQRCode.TabStop = false;
            // 
            // NotificationDeviceRequired
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 493);
            Controls.Add(picBoxQRCode);
            Controls.Add(btnNext);
            Controls.Add(linkLblPlayStore);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NotificationDeviceRequired";
            Padding = new Padding(20);
            Text = "Setup";
            Load += NotificationDeviceRequired_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxQRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private LinkLabel linkLblPlayStore;
        private BaseButton btnNext;
        private PictureBox picBoxQRCode;
    }
}