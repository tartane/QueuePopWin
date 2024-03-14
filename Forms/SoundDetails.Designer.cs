namespace QueuePopDesktop
{
    partial class SoundDetails
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
            lstSoundFiles = new ListView();
            colSoundTitle = new ColumnHeader();
            colDescription = new ColumnHeader();
            btnOK = new CustomControls.BaseButton();
            lblGameTitle = new Label();
            SuspendLayout();
            // 
            // lstSoundFiles
            // 
            lstSoundFiles.Columns.AddRange(new ColumnHeader[] { colSoundTitle, colDescription });
            lstSoundFiles.Location = new Point(12, 56);
            lstSoundFiles.Name = "lstSoundFiles";
            lstSoundFiles.Size = new Size(640, 219);
            lstSoundFiles.TabIndex = 0;
            lstSoundFiles.UseCompatibleStateImageBehavior = false;
            lstSoundFiles.View = View.Details;
            // 
            // colSoundTitle
            // 
            colSoundTitle.Text = "Sound Title";
            colSoundTitle.Width = 130;
            // 
            // colDescription
            // 
            colDescription.Text = "Description";
            colDescription.Width = 500;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.FromArgb(100, 102, 110);
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(544, 287);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(108, 46);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblGameTitle
            // 
            lblGameTitle.AutoSize = true;
            lblGameTitle.ForeColor = Color.White;
            lblGameTitle.Location = new Point(12, 23);
            lblGameTitle.Name = "lblGameTitle";
            lblGameTitle.Size = new Size(105, 20);
            lblGameTitle.TabIndex = 6;
            lblGameTitle.Text = "Sound files for";
            // 
            // SoundDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 345);
            Controls.Add(lblGameTitle);
            Controls.Add(btnOK);
            Controls.Add(lstSoundFiles);
            MaximizeBox = false;
            Name = "SoundDetails";
            Text = "Game sound list";
            Load += SoundDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstSoundFiles;
        private CustomControls.BaseButton btnOK;
        private ColumnHeader colSoundTitle;
        private ColumnHeader colDescription;
        private Label lblGameTitle;
    }
}