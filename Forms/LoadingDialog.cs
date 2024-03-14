namespace QueuePopDesktop
{
    public partial class LoadingDialog : BaseForm
    {
        public LoadingDialog(string? text = null)
        {
            InitializeComponent();

            if (text != null)
            {
                lblLoading.Text = text;
            }

        }

        public void setProgress(int progress)
        {
            progBarLoading.Value = progress;
            Update();
        }

        public void setMaxValue(int max)
        {
            progBarLoading.Maximum = max;
            Update();
        }

        public void updateText(string text)
        {
            lblLoading.Text = text;
        }
    }
}
