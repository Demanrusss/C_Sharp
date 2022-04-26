using System;
using System.Windows.Forms;

namespace InterfaceProject
{
    public partial class Form1 : Form
    {
        // Initialization of variables
        Person person = new Person("Michail", "Flenov");
        Object personObject;
        IPurse purse;

        public Form1()
        {
            InitializeComponent();

            // Initialization of variables
            personObject = person;
            purse = person;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputLabel.Text = person.FirstName + " " + person.LastName;
        }

        // Adding money to purse
        private void addButton_Click(object sender, EventArgs e)
        {
            if (personObject is IPurse)
            {
                ((IPurse)personObject).AddMoney((int)numericUpDown.Value);
                sumLabel.Text = ((IPurse)personObject).Sum.ToString();
            }
        }
        
        // Deducting money in purse
        private void decButton_Click(object sender, EventArgs e)
        {
            purse.DecMoney((int)numericUpDown.Value);
            sumLabel.Text = purse.Sum.ToString();
        }
    }
}
