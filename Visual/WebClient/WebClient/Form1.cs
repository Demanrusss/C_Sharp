using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WebClient
{
    public partial class Form1 : Form
    {
        WebRequest request;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadUrlButton_Click(object sender, EventArgs e)
        {
            if (useProxyCheckBox.Checked)
            {
                try
                {
                    WebProxy proxy = new WebProxy(addressTextBox.Text, Int32.Parse(portTextBox.Text));
                    proxy.Credentials = new NetworkCredential(userTextBox?.Text, passwordTextBox?.Text);

                    request.Proxy = proxy;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Could not load a file. Maybe, because of proxy\n{ex}");
                    return;
                }
            }

            try
            {
                request = HttpWebRequest.Create(urlTextBox.Text);
                
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                StringBuilder pagebuilder = new StringBuilder();

                string line;
                while ((line = reader.ReadLine()) != null)
                    pagebuilder.AppendLine(line);

                response.Close();
                reader.Close();
                richTextBox1.Text = pagebuilder.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load a file");
                return;
            }
        }

        private void useProxyCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (useProxyCheckBox.Checked)
            {
                addressTextBox.Enabled = true;
                portTextBox.Enabled = true;
                userTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
            }
        }

        private void useProxyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            addressTextBox.Enabled = false;
            portTextBox.Enabled = false;
            userTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
        }
    }
}
