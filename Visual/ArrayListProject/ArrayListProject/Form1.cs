using System;
using System.Windows.Forms;
using PersonClass;

namespace ArrayListProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Person person = new Person("Name", "Surname");

            person.AddChild("Andrei", "Ivanov");
            person.AddChild("Sasha", "Ivanov");
            person.AddChild("Pavel", "Kruchev");

            person.SortChildren();

            //int i = 0;

            foreach (Person p in person)
            {
                listBox1.Items.Add(p.ToString());
            }
        }
    }
}
