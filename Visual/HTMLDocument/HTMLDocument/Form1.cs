using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLDocument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            urlsListBox.Items.Clear();

            // Loading web-page to our browser
            WebBrowser browser = new WebBrowser();
            browser.Navigate(urlTextBox.Text);

            while (browser.ReadyState != WebBrowserReadyState.Complete)
                Application.DoEvents();

            // Getting all tags <a> and enumerate it
            HtmlElementCollection elementsByTagName =
                browser.Document.GetElementsByTagName("a");

            foreach (HtmlElement element in elementsByTagName)
                urlsListBox.Items.Add(element.GetAttribute("href"));

            foreach (Control c in browserPanel.Controls)
                c.Dispose();

            browserPanel.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
