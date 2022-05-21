using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SumOfTwoBigNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSumUp_Click(object sender, EventArgs e)
        {
            if (textBoxFirstInteger.Text != null && textBoxSecondInteger.Text != null)
            {
                if (textBoxFirstInteger.Text.Length > textBoxSecondInteger.Text.Length)
                    textBoxResult.Text = Sum(textBoxFirstInteger.Text.ToString(), textBoxSecondInteger.Text.ToString());
                else
                    textBoxResult.Text = Sum(textBoxSecondInteger.Text.ToString(), textBoxFirstInteger.Text.ToString());
            }
                
        }

        private string Sum(string bigInteger1, string bigInteger2)
        {
            Stack<int> stackFirst = new Stack<int>();           // Always bigger or equil to second one
            Stack<int> stackSecond = new Stack<int>();
            Stack<int> stackResult = new Stack<int>();

            foreach (char i in bigInteger1)
            {
                if ((int)i >= 48 && (int)i <= 57)               // ASCII
                    stackFirst.Push(int.Parse(i.ToString()));
            }

            foreach (char i in bigInteger2)
            {
                if ((int)i >= 48 && (int)i <= 57)               //ASCII
                    stackSecond.Push(int.Parse(i.ToString()));
            }

            // Main maths for every symbol converted to int
            int a = 0, b = 0, temp = 0;

            while (stackFirst.Count > 0)
            {
                a = stackFirst.Pop();

                if (stackSecond.Count > 0)
                    b = stackSecond.Pop();
                else
                    b = 0;

                stackResult.Push((a + b) % 10 + temp);

                if (a + b >= 10)
                    temp = 1;
                else
                    temp = 0;
            }

            if (temp == 1)
                stackResult.Push(temp);

            // Getting result from (int)stack to string
            string result = null;

            foreach (int i in stackResult)
                result = result + i.ToString();

            return result;
        }
    }
}
