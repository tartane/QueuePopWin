namespace QueuePopDesktop.CustomControls
{
    internal class BaseButton : Button
    {
        public BaseButton() : base()
        {
            BackColor = Color.FromArgb(100, 102, 110);
            ForeColor = Color.White;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Location = new Point(251, 284);
            Size = new Size(108, 46);
            Text = "OK";
            UseVisualStyleBackColor = false;
            EnabledChanged += new EventHandler(btn_EnabledChanged);
        }
        private void btn_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled == false)
            {
                BackColor = Color.FromArgb(71, 74, 81);
            }
            else
            {
                BackColor = Color.FromArgb(100, 102, 110);
            }
        }


    }
}
