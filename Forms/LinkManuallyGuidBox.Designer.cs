using QueuePopDesktop.CustomControls;

namespace QueuePopDesktop
{
    partial class LinkManuallyGuidBox
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
            txtGuid = new TextBox();
            btnDone = new BaseButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtGuid
            // 
            txtGuid.Location = new Point(23, 136);
            txtGuid.Name = "txtGuid";
            txtGuid.ReadOnly = true;
            txtGuid.Size = new Size(359, 27);
            txtGuid.TabIndex = 0;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(100, 102, 110);
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDone.ForeColor = Color.White;
            btnDone.Location = new Point(274, 245);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(108, 46);
            btnDone.TabIndex = 8;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 62);
            label1.Name = "label1";
            label1.Size = new Size(359, 47);
            label1.TabIndex = 9;
            label1.Text = "Copy the guid below in the notification device. (including hyphens)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LinkManuallyGuidBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 314);
            Controls.Add(label1);
            Controls.Add(btnDone);
            Controls.Add(txtGuid);
            Name = "LinkManuallyGuidBox";
            Padding = new Padding(20);
            Text = "Link Manually";
            Load += LinkManuallyGuidBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGuid;
        private BaseButton btnDone;
        private Label label1;
    }
}