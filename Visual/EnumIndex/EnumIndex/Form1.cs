using System;
using System.Windows.Forms;

namespace EnumIndex
{
    public partial class Form1 : Form
    {
        public enum MyColors
        {
            Red = 100,
            Green = 200,
            Blue = 300
        }

        public Form1()
        {
            InitializeComponent();

            foreach (string str in Enum.GetNames(typeof(MyColors)))
                myColorComboBox.Items.Add(str);
            foreach (int i in Enum.GetValues(typeof(MyColors)))
                IndexesComboBox.Items.Add(i);
        }

        public class Test
        {
            Form1.MyColors myTestColor;
        }

        private void myColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentColor = myColorComboBox.SelectedItem.ToString();
            MyColors myColor = (MyColors)Enum.Parse(typeof(MyColors), currentColor);
            selectedValueLabel.Text = myColor.ToString();
        }
    }
}
