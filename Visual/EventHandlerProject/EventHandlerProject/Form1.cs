using System;
using System.Windows.Forms;

namespace EventHandlerProject
{
    public partial class Form1 : Form
    {
        Person person = new Person("Alexei", "Ivanov");

        public Form1()
        {
            InitializeComponent();

            ageNumericUpDown.Value = person.Age;
            // Register the event
            person.AgeChanged += delegate (object sender, EventArgs e)
            {
                Person person = (Person)sender;
                MessageBox.Show("Age changed to " + person.Age.ToString());
            };

            person.FirstNameChanged += new Person.NameChanged(FirstNameChanged);
            person.LastNameChanged += new Person.NameChanged(LastNameChanged);
        }

        private void FirstNameChanged(object sender, NameChangedEvent e)
        {
            Person person = (Person)sender;
            MessageBox.Show("Name has been changed to " + firstNameTextBox.Text);
        }

        private void LastNameChanged(object sender, NameChangedEvent e)
        {
            Person person = (Person)sender;
            if (MessageBox.Show("Surname is going to be changed from " +
                person.Lastname.ToString() + " to " + e.NewName, "Attention",
                MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Canceled = true;
            }
                
        }

        private void ageChangedButton_Click(object sender, EventArgs e)
        {
            person.Age = (int)ageNumericUpDown.Value;
            ageLabel.Text = person.Age.ToString();
        }

        private void firstNameChangedButton_Click(object sender, EventArgs e)
        {
            person.Firstname = (string)firstNameTextBox.Text;
            firstNameLabel.Text = person.Firstname.ToString();
        }

        private void lastNameChangedButton_Click(object sender, EventArgs e)
        {
            person.Lastname = (string)lastNameTextBox.Text;
            lastNameLabel.Text = person.Lastname.ToString();
        }
    }
}
