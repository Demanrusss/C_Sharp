using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileStreamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            // Show a window of choice
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            // Additional variables
            byte[] bufer = new byte[100];
            ASCIIEncoding ascii = new ASCIIEncoding();

            // Load a file
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, 
                FileAccess.ReadWrite);
            int readed = fs.Read(bufer, 0, 100);

            while (readed > 0)
            {
                richTextBox1.AppendText(ascii.GetString(bufer, 0, readed));
                readed = fs.Read(bufer, 0, 100);
            }
        }
    }
}
