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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person person = new Person("Sergei", "Ivanov");

            person.AddChild("Sergei", "Ivanov");
            person.AddChild("Alexei", "Ivanov");
            person.AddChild("Valya", "Ivanov");

            person.SortChildren();
        }
    }
}
