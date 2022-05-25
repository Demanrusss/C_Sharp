using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(textBox1.Text);
                MessageBox.Show($"You have entered {index}");
            }
            catch (FormatException)
            {
                MessageBox.Show($"You have entered incorrect number");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unknown problem: {ex.Message}");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index;

            try
            {
                index = Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show($"You have entered incorrect number");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unknown problem: {ex.Message}");
                return;
            }

            if (index < 0)
                throw new Exception("You have entered a number < 0");
            if (index > 1000)
                throw new Exception("You have entered a number > 1000");

            MessageBox.Show($"You have entered {index}");
        }
    }
}
