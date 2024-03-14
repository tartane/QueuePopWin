using QueuePopDesktop.CustomControls;

namespace QueuePopDesktop
{
    partial class ReportIssue
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
            txtTitle = new TextBox();
            label1 = new Label();
            txtDescription = new TextBox();
            label2 = new Label();
            btnReport = new BaseButton();
            btnCancel = new BaseButton();
            label3 = new Label();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(23, 128);
            txtTitle.MaxLength = 500;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(436, 27);
            txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 105);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(23, 192);
            txtDescription.MaxLength = 5000;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(436, 224);
            txtDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 169);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(100, 102, 110);
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(351, 434);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(108, 46);
            btnReport.TabIndex = 4;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_ClickAsync;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(100, 102, 110);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(237, 434);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 46);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 44);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 67);
            txtEmail.MaxLength = 500;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(436, 27);
            txtEmail.TabIndex = 8;
            // 
            // ReportIssue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 51, 56);
            ClientSize = new Size(482, 503);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(btnCancel);
            Controls.Add(btnReport);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            MaximizeBox = false;
            Name = "ReportIssue";
            Padding = new Padding(20);
            Text = "Report issue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label label1;
        private TextBox txtDescription;
        private Label label2;
        private BaseButton btnReport;
        private BaseButton btnCancel;
        private Label label3;
        private TextBox txtEmail;
    }
}