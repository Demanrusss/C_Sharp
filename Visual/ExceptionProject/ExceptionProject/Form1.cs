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

        private void button1_Click(object sender, EventArgs e)
        {
            CarEngine engine;

            try
            {
                engine.StartEngine();
            }
            catch (EngineException ex)
            {
                MessageBox.Show("The engine '" + ex.Engine.Name + "'\nIt generated a mistake: '" 
                    + ex.Message + "'");
            }
        }
    }
}
