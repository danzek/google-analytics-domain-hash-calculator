using System;
using System.Windows.Forms;

namespace GoogleDomainHashCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string hash(string d)
        {
            // see https://developers.google.com/analytics/devguides/collection/analyticsjs/cookie-usage
            // from SO answer found at https://stackoverflow.com/q/4821627/
            // there is also C++ code in my Gist: https://gist.github.com/danzek/8bc7820dfefa025e681bc4f4a7a02627
            int a = 1;
            int c = 0;
            int h;
            int o;
            if (!String.IsNullOrEmpty(d))
            {
                a = 0;
                for (h = d.Length - 1; h >= 0; h--)
                {
                    o = d[h];
                    a = (a << 6 & 268435455) + o + (o << 14);
                    c = a & 266338304;
                    a = c != 0 ? a ^ c >> 21 : a;
                }
            }
            return a.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDomain.Text.Trim()))
            {
                MessageBox.Show("Please enter a domain.", "Missing required field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            } else if (txtDomain.Text.Trim().StartsWith("http"))
            {
                MessageBox.Show("Please read the directions (do not include the protocol, e.g., \"http://\").", "Improperly formatted domain (RTFM)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            } else
            {
                try
                {
                    txtDomainHash.Text = hash(txtDomain.Text.Trim());
                } catch (System.Exception ex)
                {
                    MessageBox.Show(string.Format("Error: {0}", ex.Message), "Missing required field", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnCopyCB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDomainHash.Text.Trim()))
            {
                Clipboard.SetText(txtDomainHash.Text.Trim());
            }
        }
    }
}
