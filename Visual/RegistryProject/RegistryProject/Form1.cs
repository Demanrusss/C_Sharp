using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegistryProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadProgramProperties();
        }

        private void SaveProgramProperties()
        {
            RegistryKey registryKeyOptions = Registry.CurrentUser;
            registryKeyOptions = registryKeyOptions.CreateSubKey("Software");
            registryKeyOptions = registryKeyOptions.CreateSubKey("Bible");
            registryKeyOptions = registryKeyOptions.CreateSubKey("Examples");

            registryKeyOptions.SetValue("WinState", (int)WindowState);

            if (WindowState == FormWindowState.Normal)
            {
                registryKeyOptions.SetValue("width", Width);
                registryKeyOptions.SetValue("height", Height);
                registryKeyOptions.SetValue("left", Left);
                registryKeyOptions.SetValue("top", Top);
            }
        }

        private void LoadProgramProperties()
        {
            RegistryKey registryKeyOptions = Registry.CurrentUser;
            registryKeyOptions = registryKeyOptions.CreateSubKey("Software");
            registryKeyOptions = registryKeyOptions.CreateSubKey("Bible");
            registryKeyOptions = registryKeyOptions.CreateSubKey("Examples");

            Width = (int)registryKeyOptions.GetValue("width", 600);
            Height = (int)registryKeyOptions.GetValue("height", 400);
            Left = (int)registryKeyOptions.GetValue("left", 50);
            Top = (int)registryKeyOptions.GetValue("top", 50);

            WindowState = (FormWindowState)registryKeyOptions.GetValue("WinState",
                FormWindowState.Normal);
            registryKeyOptions.Close();
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
           MessageBox.Show("I will save form properties");
           SaveProgramProperties();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(this.Form1_Closing);
        }

        private void GetFormValuesButton_Click(object sender, EventArgs e)
        {
            RegistryKey registryKeyOptions = Registry.CurrentUser;
            registryKeyOptions = registryKeyOptions.CreateSubKey("Software");
            registryKeyOptions = registryKeyOptions.CreateSubKey("Bible");
            registryKeyOptions = registryKeyOptions.CreateSubKey("Examples");

            String[] names = registryKeyOptions.GetValueNames();
            textBox1.Lines = names;
        }
    }
}
