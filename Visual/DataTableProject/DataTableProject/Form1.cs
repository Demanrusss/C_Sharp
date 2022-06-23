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

        private void addRowButton_Click(object sender, EventArgs e)
        {
            DataRow row = table.NewRow();
            row[1] = "Milk";
            row["Quantity"] = 10;
            row["Price"] = 16;
            table.Rows.Add(row);
        }

        private void loadDataRowButton_Click(object sender, EventArgs e)
        {
            Object[] row = { null, "Sugar", 2, 23, null, null};
            table.LoadDataRow(row, false);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // Checking for existence of rows
            if (table.Rows.Count == 0)
                return;

            DataRow row = table.Rows[0];
            row[1] = "Sugar";
        }

        private void editTransactionButton_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count < 3)
                return;

            table.BeginInit();
            DataRow row = table.Rows[1]; // Getting first row
            row[2] = (int)row[2] - 10;   // Decreasing a value at the second pole

            row = table.Rows[2];         // Getting second row
            row[2] = (int)row[2] + 10;   // increasing a value at the third pole
            table.EndInit();             // Events are generating in here
        }

        private void findAndEditButton_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
                return;

            try
            {
                DataRow row = table.Rows.Find(20);
                row[1] = "Found and Edited";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong with {ex}");
                return;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
                return;

            table.Rows.Remove(table.Rows[0]);
        }
    }
}
