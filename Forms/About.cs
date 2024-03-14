using QueuePopDesktop.Properties;
using System.Diagnostics;

namespace QueuePopDesktop
{
    public partial class About : BaseForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            lblVersion.Text = $"Version {Application.ProductVersion}";
        }

        private void linkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://www.qpop.gg/");
            }
            catch
            {
                Process.Start(new ProcessStartInfo("https://www.qpop.gg/") { UseShellExecute = true });
            }
        }
    }
}
