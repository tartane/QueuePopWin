using QueuePopDesktop.CustomControls;

namespace QueuePopDesktop
{
    partial class AskForUpdate
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
            btnUpdate = new BaseButton();
            btnLater = new BaseButton();
            chkDontAsk = new CheckBox();
            btnCancel = new BaseButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(361, 56);
            label1.TabIndex = 0;
            label1.Text = "A new version of Queue Pop is available.\r\nWould you like to download it?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(100, 102, 110);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(273, 132);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 46);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnLater
            // 
            btnLater.BackColor = Color.FromArgb(100, 102, 110);
            btnLater.FlatStyle = FlatStyle.Flat;
            btnLater.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLater.ForeColor = Color.White;
            btnLater.Location = new Point(159, 132);
            btnLater.Name = "btnLater";
            btnLater.Size = new Size(108, 46);
            btnLater.TabIndex = 7;
            btnLater.Text = "Later";
            btnLater.UseVisualStyleBackColor = true;
            btnLater.Click += btnLater_Click;
            // 
            // chkDontAsk
            // 
            chkDontAsk.AutoSize = true;
            chkDontAsk.ForeColor = Color.White;
            chkDontAsk.Location = new Point(23, 97);
            chkDontAsk.Name = "chkDontAsk";
            chkDontAsk.Size = new Size(158, 24);
            chkDontAsk.TabIndex = 8;
            chkDontAsk.Text = "Don't ask me again";
            chkDontAsk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(100, 102, 110);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(20, 132);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 46);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AskForUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 51, 56);
            ClientSize = new Size(404, 197);
            Controls.Add(btnCancel);
            Controls.Add(chkDontAsk);
            Controls.Add(btnLater);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Name = "AskForUpdate";
            Padding = new Padding(20);
            Text = "Update";
            Load += AskForUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private BaseButton btnUpdate;
        private BaseButton btnLater;
        private CheckBox chkDontAsk;
        private BaseButton btnCancel;
    }
}