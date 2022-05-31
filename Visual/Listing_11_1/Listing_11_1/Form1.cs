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
    }
}
