using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceProject2
{
    public partial class Form1 : Form
    {
        //Announcing variables
        Person person = new Person("Michail", "Flenov");
        IPurse purse;

        public Form1()
        {
            InitializeComponent();
        }
    }
}
