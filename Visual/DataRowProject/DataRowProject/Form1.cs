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

namespace DataRowProject
{
    public partial class Form1 : Form
    {
        private DataSet _dataSet = new DataSet();

        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        OleDbConnection CreateConnection()
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

        private void ReadData()
        {
            // Connecting to DB
            OleDbConnection connection = CreateConnection();

            OleDbDataAdapter adapter = new OleDbDataAdapter(
                "SELECT * FROM Peoples", connection);

            adapter.Fill(_dataSet);

            connection.Close();

            _dataSet.Tables[0].Columns.Add("ФИО", typeof(String), "Фамилия + ' ' + Имя");

            // Filling in column names
            foreach (DataColumn column in _dataSet.Tables[0].Columns)
                listView1.Columns.Add(column.Caption);

            // Filling in rows
            foreach (DataRow row in _dataSet.Tables[0].Rows)
            {
                ListViewItem item = listView1.Items.Add(row.ItemArray[0].ToString());

                for (int i = 1; i < row.ItemArray.Length; i++)
                    item.SubItems.Add(row.ItemArray[i].ToString());
            }

            // Looking for constraints
            foreach (Constraint ct in _dataSet.Tables[0].Constraints)
            {
                if (ct is UniqueConstraint)
                {
                    foreach (DataColumn column in ((UniqueConstraint)ct).Columns)
                        MessageBox.Show(column.Caption);
                }
            }

            // Looking for PrimaryKey
            _dataSet.Tables[0].PrimaryKey = 
                new DataColumn[] { _dataSet.Tables[0].Columns[0]};

            foreach (Constraint ctPK in _dataSet.Tables[0].Constraints)
                if (ctPK is UniqueConstraint)
                    MessageBox.Show(_dataSet.Tables[0].Columns[0].Caption);
        }
    }
}
