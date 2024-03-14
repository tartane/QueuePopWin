using QueuePopDesktop.Properties;
using System.Diagnostics;

namespace QueuePopDesktop
{
    public partial class AskForUpdate : BaseForm
    {

        private float NewVersionNumber { get; set; }

        private bool ManualAskUpdate { get; set; }

        public AskForUpdate(float newVersionNumber, bool manualAskUpdate)
        {
            NewVersionNumber = newVersionNumber;
            ManualAskUpdate = manualAskUpdate;

            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.qpop.gg/download");
            }
            catch
            {
                Process.Start(new ProcessStartInfo("https://www.qpop.gg/download") { UseShellExecute = true });
            }

            Application.Exit();
        }

        private void btnLater_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (chkDontAsk.Checked) {
                Settings.Default.dont_ask_for_update_version = NewVersionNumber;
                Settings.Default.Save();
            }

            Close();
        }

        private void AskForUpdate_Load(object sender, EventArgs e)
        {
            chkDontAsk.Visible = !ManualAskUpdate;
        }
    }
}
