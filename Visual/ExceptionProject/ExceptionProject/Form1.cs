using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CarEngine engine = new CarEngine("Number 1");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                engine.StartEngine();
            }
            catch (EngineException ex)
            {
                MessageBox.Show("Engine '" + ex.Engine.Name + "'\ngenerated the exception: '" + ex.Message + "'");
            }
        }
    }
}
