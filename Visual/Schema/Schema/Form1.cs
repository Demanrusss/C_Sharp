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

namespace Schema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        private void ReadData()
        {
            OleDbConnection connection = CreateConnection();

            // Getting tables from DB
            Object[] dbrestrinct = { "TestDatabase", null, null, null};
            DataTable table = 
                connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, 
                    dbrestrinct);

            foreach (DataRow row in table.Rows)
                tablesListBox.Items.Add(row["TABLE_NAME"]);

            // Getting schema of columns
            Object[] clmnrestrinct = { "TestDatabase", null, "Peoples", null };
            DataTable columns = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns,
                clmnrestrinct);

            foreach (DataRow row in columns.Rows)
                columnsListBox.Items.Add(row["COLUMN_NAME"]);
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
    }
}
