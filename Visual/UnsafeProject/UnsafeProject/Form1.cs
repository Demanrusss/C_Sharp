using System;
using System.Windows.Forms;

namespace UnsafeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            int index = 10;

            unsafe
            {
                int* point = &index;

                // Show the value and address
                listBox1.Items.Add("The value of address: " + *point);
                listBox1.Items.Add("Address: " + (int)point);

                // Increment of pointer
                point++;

                // Show the value and address
                listBox1.Items.Add("The value of address: " + *point);
                listBox1.Items.Add("Address: " + (int)point);
            }
        }

        private void addPointButton_Click(object sender, EventArgs e)
        {
            // Clear up listBox
            listBox1.Items.Clear();
            
            unsafe
            {
                Point point = new Point(0, 0);

                // Unfortunately from C# 8.0 it doesn't work
                Point* ptr = &point; 

                ptr->X = 10;
                ptr->Y = 20;

                listBox1.Items.Add("The value of X: " + ptr->X);
                listBox1.Items.Add("The value of Y: " + ptr->Y);
            }
        }
    }
}
