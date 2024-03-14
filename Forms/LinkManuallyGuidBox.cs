using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuePopDesktop
{
    public partial class LinkManuallyGuidBox : BaseForm
    {

        public Guid guid
        {
            get => (Guid)Properties.Settings.Default["guid"];
        }

        public LinkManuallyGuidBox()
        {
            InitializeComponent();
        }

        private void LinkManuallyGuidBox_Load(object sender, EventArgs e)
        {
            CenterToParent();
            txtGuid.Text = guid.ToString();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
