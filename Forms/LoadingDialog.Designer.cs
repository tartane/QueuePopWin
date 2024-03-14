namespace QueuePopDesktop
{
    partial class LoadingDialog
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
            progBarLoading = new ProgressBar();
            lblLoading = new Label();
            SuspendLayout();
            // 
            // progBarLoading
            // 
            progBarLoading.Location = new Point(58, 65);
            progBarLoading.Name = "progBarLoading";
            progBarLoading.Size = new Size(349, 29);
            progBarLoading.TabIndex = 0;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.ForeColor = Color.White;
            lblLoading.Location = new Point(26, 37);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(72, 20);
            lblLoading.TabIndex = 1;
            lblLoading.Text = "Loading...";
            // 
            // LoadingDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 160);
            ControlBox = false;
            Controls.Add(lblLoading);
            Controls.Add(progBarLoading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingDialog";
            Text = "LoadingDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progBarLoading;
        private Label lblLoading;
    }
}