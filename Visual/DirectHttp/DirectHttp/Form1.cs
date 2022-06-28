using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace DirectHttp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            HttpClient httpClient = new HttpClient();

            if (urlTextBox.Text != "")
            {
                try
                {
                    richTextBox1.Text = httpClient.GetPageStatus(new Uri(urlTextBox.Text)).ToString();
                    richTextBox1.Text = httpClient.PageContent.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong with " + ex.Message);
                    return;
                }
            }
        }

        private void enterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loadButton_Click(sender, e);
        }
    }
}
