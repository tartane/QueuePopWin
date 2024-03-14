using QRCoder;
using QueuePopDesktop.Properties;
using System.Diagnostics;

namespace QueuePopDesktop
{
    public partial class QRCodeScan : BaseForm
    {
        private readonly string GUID_DEFAULT = "00000000-0000-0000-0000-000000000000";

        public QRCodeScan()
        {
            InitializeComponent();

            if (Settings.Default.guid.ToString() == GUID_DEFAULT)
                refreshQRCode();
            else
                setupQRCode();
        }

        private void generateNewGuid()
        {
            Settings.Default.guid = Guid.NewGuid();
            Settings.Default.Save();
        }

        private void setupQRCode()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(Settings.Default.guid.ToString(), QRCodeGenerator.ECCLevel.L);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);
            picBoxQRCode.Image = qrCodeImage;
        }

        private void refreshQRCode()
        {
            generateNewGuid();
            setupQRCode();
        }

        private void lblLinkManually_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LinkManuallyGuidBox().ShowDialog();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Every device linked with this code won't receive notifications anymore. You will have to link them again.\n\nWould you like to continue?", "Refresh QR Code", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                refreshQRCode();
                MessageBox.Show("QR code refreshed successfully!\n\nYou can now use the new code to link your notification devices.", "QR Code Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnQrCode_Click(object sender, EventArgs e)
        {
            new NotificationDeviceRequired(false).ShowDialog();
        }

        private void linkLblPlayStore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://play.google.com/store/apps/details?id=com.queuepopcompanion");
            }
            catch
            {
                Process.Start(new ProcessStartInfo("https://play.google.com/store/apps/details?id=com.queuepopcompanion") { UseShellExecute = true });
            }
        }
    }
}
