using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace TextFileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            // Show a window of choices
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files|*.txt|All files|*.*";

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            // Create a list for data
            List<string> fileLines = new List<string>();

            // Create an object of reading
            StreamReader reader = new StreamReader(ofd.FileName);

            // Loop of reading
            while (true)
            {
                String s = reader.ReadLine();
                if (s == null)
                    break;

                fileLines.Add(s);
            }

            reader.Close(); // Close the file

            // Update textBox with the data from the file
            textBox1.Lines = fileLines.ToArray();
        }
    }
}
