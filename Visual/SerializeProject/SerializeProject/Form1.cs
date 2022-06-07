using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SerializeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Initialization of Person class object
            Person person = new Person();

            // Saving data from the form to properties
            person.Name = nameTextBox.Text;
            person.Surname = surnameTextBox.Text;
            person.Age = (int)ageNumericUpDown.Value;
            person.Birthday = birthdayDateTimePicker.Value;

            // Creating an object of serialization
            BinaryFormatter formatter = new BinaryFormatter();

            // Creating an object of file stream
            FileStream fstream = new FileStream("person.dat", FileMode.Create,
                FileAccess.Write);

            // Serialization
            formatter.Serialize(fstream, person);

            // Closing stream
            fstream.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            // Create an object BinaryFormatter for reading from file
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            // Creating a stream to work with a file
            FileStream fstream = new FileStream("person.dat", FileMode.Open, FileAccess.Read);

            // Loading data
            Person person = (Person)binaryFormatter.Deserialize(fstream);

            // Closing the file
            fstream.Close();

            // Copying properties of Person class into form fields
            nameTextBox.Text = person.Name;
            surnameTextBox.Text = person.Surname;
            ageNumericUpDown.Value = person.Age;
            birthdayDateTimePicker.Value = person.Birthday;
        }
    }
}
