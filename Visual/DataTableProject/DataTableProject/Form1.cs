using System;
using System.Data;
using System.Windows.Forms;

namespace DataTableProject
{
    public partial class Form1 : Form
    {
        DataTable table;
        BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            // Table columns
            DataColumn c = table.Columns.Add("idKey", typeof(String));
            c.AutoIncrement = true;
            c.AutoIncrementSeed = 10;
            c.AutoIncrementStep = 5;
            c.ReadOnly = true;

            table.Columns.Add("Goods", typeof(String));
            table.Columns.Add("Quantity", typeof(Int32));
            table.Columns.Add("Price", typeof(Int32));
            table.Columns.Add("Total", typeof(String), "Quantity * Price");
            table.Columns.Add("More than 100", typeof(Boolean), "Quantity * Price > 100");
            table.Columns.Add("Sum", typeof(String), "Sum(Quantity)");

            // Binding and fill in dataGridView
            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource;
        }
    }
}
