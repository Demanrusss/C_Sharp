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

namespace DirFileProject
{
    public partial class Form1 : Form
    {
        string FPath = "C:\\";
        public Form1()
        {
            InitializeComponent();
            GetFiles();
        }

        void GetFiles()
        {
            // Start updating
            fmListView.BeginUpdate();
            fmListView.Items.Clear();

            // Get list of directories
            string[] dirs = Directory.GetDirectories(FPath);
            foreach (string dir in dirs)
            {
                string dirName = Path.GetFileName(dir);
                fmListView.Items.Add(dirName, 1);
            }

            // Get list of files
            string[] files = Directory.GetFiles(FPath);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                if ((File.GetAttributes(file) & FileAttributes.Hidden) == FileAttributes.Hidden)
                    if (hideFilesCheckBox.Checked)
                        continue;

                fmListView.Items.Add(fileName, 0);
            }

            // End updating
            fmListView.EndUpdate();
        }

        private void hideFilesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetFiles();
        }

        private void fmListView_ItemActivate(object sender, EventArgs e)
        {
            if (fmListView.SelectedItems.Count == 0)
                return;

            ListViewItem item = fmListView.SelectedItems[0];

            if (item.ImageIndex == 1)
            {
                FPath = FPath + item.Text + "\\";
                GetFiles();
            }
        }

        private void parentDirectoryButton_Click(object sender, EventArgs e)
        {
            if (Directory.GetParent(FPath) != null)
            {
                FPath = Directory.GetParent(FPath).FullName.Replace(Directory.GetParent(FPath).Name, "");
                GetFiles();
            }
        }
    }
}
