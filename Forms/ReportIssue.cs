using QueuePopDesktop.Models;
using QueuePopDesktop.Properties;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace QueuePopDesktop
{
    public partial class ReportIssue : BaseForm
    {
        public ReportIssue()
        {
            InitializeComponent();
        }

        private bool validateFields()
        {
            var email = new EmailAddressAttribute();

            return
                !string.IsNullOrWhiteSpace(txtTitle.Text) &&
                !string.IsNullOrWhiteSpace(txtDescription.Text) &&
                !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                email.IsValid(txtEmail.Text);
        }

        async Task<bool> sendIssue()
        {
            Issue issue = new Issue()
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                Email = txtEmail.Text,
                DesktopVersion = float.Parse(Application.ProductVersion, CultureInfo.InvariantCulture.NumberFormat),
                Guid = Settings.Default.guid
            };

            return await QueuePopService.ReportIssueAsync(issue);
        }

        private async void btnReport_ClickAsync(object sender, EventArgs e)
        {
            if (validateFields())
            {
                using (new AppWaitCursor(sender))
                {
                    var isSuccess = await sendIssue();
                    if (isSuccess)
                    {
                        MessageBox.Show("Thank you!\n\nYour issue has been sent successfully", "Report Issue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(
                                "An error has occurred when sending your report. Please try again.",
                                "Report error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                    }

                }
            }
            else
            {
                MessageBox.Show(
                        "Title, Description and Email fields are required. Email field must be valid.",
                        "Validation error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
