using QRCoder;
using QueuePopDesktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuePopDesktop
{
    public partial class NotificationDeviceRequired : BaseForm
    {
        public bool openedFromSetup { get; set; }
        public NotificationDeviceRequired(bool openedFromSetup)
        {
            InitializeComponent();
            this.openedFromSetup = openedFromSetup;
        }

        private void NotificationDeviceRequired_Load(object sender, EventArgs e)
        {
            Settings.Default.is_first_run = false;
            Settings.Default.Save();

            setupQRCode();
        }

        private void setupQRCode()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://play.google.com/store/apps/details?id=com.queuepopcompanion", QRCodeGenerator.ECCLevel.L);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);
            picBoxQRCode.Image = qrCodeImage;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (openedFromSetup) {
                new QRCodeScan().ShowDialog();
            }
            
            Close();
        }
    }
}
