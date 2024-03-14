using QueuePopDesktop.CustomControls;

namespace QueuePopDesktop
{
    partial class About
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
            label1 = new Label();
            lblVersion = new Label();
            label3 = new Label();
            btnOk = new BaseButton();
            linkWebsite = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(220, 54);
            label1.TabIndex = 0;
            label1.Text = "Queue Pop";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.White;
            lblVersion.Location = new Point(32, 72);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(103, 28);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Version x.x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 105);
            label3.Name = "label3";
            label3.Size = new Size(234, 46);
            label3.TabIndex = 2;
            label3.Text = "© 2023, Marc-André Therrien\r\nAll rights reserved.";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(100, 102, 110);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(251, 284);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(108, 46);
            btnOk.TabIndex = 5;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // linkWebsite
            // 
            linkWebsite.AutoSize = true;
            linkWebsite.LinkColor = Color.White;
            linkWebsite.Location = new Point(23, 297);
            linkWebsite.Name = "linkWebsite";
            linkWebsite.Size = new Size(156, 20);
            linkWebsite.TabIndex = 6;
            linkWebsite.TabStop = true;
            linkWebsite.Text = "https://www.qpop.gg/";
            linkWebsite.LinkClicked += linkWebsite_LinkClicked;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 51, 56);
            ClientSize = new Size(382, 353);
            Controls.Add(linkWebsite);
            Controls.Add(btnOk);
            Controls.Add(label3);
            Controls.Add(lblVersion);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "About";
            Padding = new Padding(20);
            Text = "About";
            Load += About_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblVersion;
        private Label label3;
        private LinkLabel linkWebsite;
        private BaseButton btnOk;
    }
}