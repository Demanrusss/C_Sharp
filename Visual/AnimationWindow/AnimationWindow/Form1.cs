using System;
using System.Windows.Forms;

namespace AnimationWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changePositionButton_Click(object sender, EventArgs e)
        {
            Win32Iface.MoveWindow(Handle, 1, 2, 600, 400, true);
        }
    }
}
