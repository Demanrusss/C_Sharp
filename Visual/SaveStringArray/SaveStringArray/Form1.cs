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

namespace SaveStringArray
{
    public partial class Form1 : Form
    {
        string fullpath;

        public Form1()
        {
            InitializeComponent();

            fullpath = Environment.GetCommandLineArgs()[0] + ".list";

            if (File.Exists(fullpath))
            {
                string[] slist = File.ReadAllLines(fullpath);
                userListBox.Items.AddRange(slist);
            }

        }

        private void addUserTextButton_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text != "")
            {
                userListBox.Items.Add(userTextBox.Text);
            }
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText(fullpath);

            foreach (string s in userListBox.Items)
                sw.WriteLine(s);

            sw.Close();
        }
    }
}
