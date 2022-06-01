using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listing_11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Person> people = SampleHelper.CreatePersons();
            IEnumerable<Person> results = people.Where(r => r.Age < 21);

            foreach (var p in results)
            {
                listBox1.Items.Add(p.Name + " " + p.Surname + ": " + p.Age);
            }

            label1.Text = "After adding another person";

            people.Add(new Person("Igor", "Sidorov", 10));

            foreach (var p in results)
            {
                listBox2.Items.Add(p.Name + " " + p.Surname + ": " + p.Age);
            }
        }

        private void toListButton_Click(object sender, EventArgs e)
        {
            // Clear up the listboxes
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            List<Person> people = SampleHelper.CreatePersons();
            // IEnumerable to ToList
            IEnumerable<Person> results = people.Where(r => r.Age < 21).ToList();

            foreach (var p in results)
            {
                listBox1.Items.Add(p.Name + " " + p.Surname + ": " + p.Age);
            }

            label1.Text = "After adding another person";

            people.Add(new Person("Igor", "Sidorov", 10));

            foreach (var p in results)
            {
                listBox2.Items.Add(p.Name + " " + p.Surname + ": " + p.Age);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear up the listboxes
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            List<Person> people = SampleHelper.CreatePersons();
            // Skip() and Take()
            IEnumerable<Person> results = people.Where(r => r.Age < 21).Skip(0).Take(3);

            foreach (var p in results)
            {
                listBox1.Items.Add(p.Name + " " + p.Surname + ": " + p.Age);
            }

            label1.Text = "After adding another person";

            people.Add(new Person("Igor", "Sidorov", 10));

            foreach (var p in results)
            {
                listBox2.Items.Add(p.Name + " " + p.Surname + ": " + p.Age);
            }
        }
    }
}
