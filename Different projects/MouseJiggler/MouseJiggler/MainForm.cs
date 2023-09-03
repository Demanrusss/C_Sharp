using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseJiggler
{
    public partial class MainForm : Form
    {
        private static Thread thread;

        [DllImport("User32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            jigPeriodTrackBar_Scroll(sender, e);
        }

        private void runJigglingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            runJigglingCheckBox.Text = runJigglingCheckBox.Checked 
                ? "Stop Jiggling" 
                : "Start Jiggling";

            JigglingThreadControl(runJigglingCheckBox.Checked);
        }

        private void JigglingThreadControl(bool startJiggling)
        {
            if (startJiggling == true)
            {
                jigPeriodTrackBar.Enabled = false;
                if (thread == null || thread.ThreadState == ThreadState.Aborted)
                {
                    thread = new Thread(RunJiggling);
                }

                thread.Start(jigPeriodTrackBar.Value);
            }
            else
            {
                thread.Abort();
                jigPeriodTrackBar.Enabled = true;
            }
        }

        private void RunJiggling(object period)
        {
            while (true)
            {
                SetCursorPos(Cursor.Position.X + 10, Cursor.Position.Y + 10);
                Thread.Sleep((int)period * 1000);
                SetCursorPos(Cursor.Position.X - 10, Cursor.Position.Y - 10);
                Thread.Sleep((int)period * 1000);
            }
        }

        private void jigPeriodTrackBar_Scroll(object sender, EventArgs e)
        {
            chosenJigPeriodLabel.Text = jigPeriodTrackBar.Value.ToString();
        }
    }
}
