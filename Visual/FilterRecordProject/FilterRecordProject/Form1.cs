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

namespace FilterRecordProject
{
    public partial class Form1 : Form
    {
        private DataSet _dataset;

        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        private void ReadData()
        {
            OleDbConnection connection = CreateConnection();

            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Peoples";

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            _dataset = new DataSet();
            adapter.Fill(_dataset);
            connection.Close();
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

        private void findPersonButton_Click(object sender, EventArgs e)
        {
            string filter = "Фамилия LIKE '" + findPersonTextBox.Text + "%'";
            DataRow[] rows = _dataset.Tables[0].Select(filter);

            string found = "";
            foreach (DataRow row in rows)
                found += row.ItemArray[1].ToString() + "\n";

            MessageBox.Show(found);
        }
    }
}
