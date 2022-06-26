using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataViewProject
{
    public partial class Form1 : Form
    {
        DataView view;

        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        private void ReadData()
        {
            OleDbConnection connection = CreateConnection();
            OleDbCommand command = new OleDbCommand("SELECT * FROM Peoples");
            command.Connection = connection;

            // Getting data to dataset
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            connection.Close();

            // Creating a view based on a table
            view = new DataView(dataset.Tables[0]);
            dataGridView1.DataSource = view;
            view.Sort = "Имя";

            view.RowFilter = "Фамилия LIKE 'И%'";

            // An example of used row status "Added"
            Object[] newRow = { null, "Matveyeva", "Matrena" };
            dataset.Tables[0].LoadDataRow(newRow, false);

            label1.Text = "After adding a row: " + newRow[1].ToString() + " " + 
                newRow[2].ToString();

            DataView view2 = new DataView(dataset.Tables[0], "", "", 
                DataViewRowState.Added);
            dataGridView2.DataSource = view2;

            
        }

        private OleDbConnection CreateConnection()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;
                Persist Security Info=False;Initial Catalog=TestDatabase;
                Data Source=localhost\SQLEXPRESS";

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Something went wrong while connecting to DB");
            }

            return connection;
        }

        private void editingButton_Click(object sender, EventArgs e)
        {
            // Only using already created view

            view.Sort = "idKey";
            DataRowView[] editrows = view.FindRows(2);

            foreach (DataRowView editrow in editrows)
                editrow[1] = "Edited";
        }

        private void editingButton1_Click(object sender, EventArgs e)
        {
            view.Sort = "Фамилия";
            DataRowView[] editrows = view.FindRows("Иванова");

            foreach (DataRowView editrow in editrows)
                editrow[1] = "Бывшая Иванова";
        }
    }
}
