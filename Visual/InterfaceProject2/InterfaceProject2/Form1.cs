using System;
using System.Windows.Forms;
using InterfaceProject2.Interfaces;

namespace InterfaceProject2
{
    public partial class Form1 : Form
    {
        // Declaring variables
        Person person = new Person("Michail", "Flenov");
        Object personObject;
        IPurse purse;

        public Form1()
        {
            InitializeComponent();

            // Initialization of variables
            personObject = person;
            purse = person;

            PersonLabel.Text = person.FirstName.ToString() + " " + person.LastName.ToString();
        }

        private void AddButtonX2_Click(object sender, EventArgs e)
        {
            person.AddMoney((int)numericUpDown.Value);
            sumLabel.Text = person.Sum.ToString();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            ((IPurse)person).AddMoney((int)numericUpDown.Value);
            sumLabel.Text = person.Sum.ToString();
        }
        private void DecButtonX2_Click(object sender, EventArgs e)
        {
            person.DecMoney((int)numericUpDown.Value);
            sumLabel.Text = person.Sum.ToString();
        }

        private void DecButton_Click(object sender, EventArgs e)
        {
            ((IPurse)person).DecMoney((int)numericUpDown.Value);
            sumLabel.Text = person.Sum.ToString();
        }

        private void AddButtonX3_Click(object sender, EventArgs e)
        {
            ((ITriplePurse)person).AddMoney((int)numericUpDown.Value);
            sumLabel.Text = person.Sum.ToString();
        }

        private void DecButtonX3_Click(object sender, EventArgs e)
        {
            ((ITriplePurse)person).DecMoney((int)numericUpDown.Value);
            sumLabel.Text = person.Sum.ToString();
        }
    }
}
