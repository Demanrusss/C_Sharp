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

namespace ParameterInSelect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection CreateConnection()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;" +
                @"Persist Security Info=False;Initial Catalog=TestDatabase;" +
                @"Data Source=localhost\SQLEXPRESS";

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

        private void selectAllFromDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = CreateConnection();

            OleDbCommand command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM Peoples " +
                "WHERE Фамилия LIKE ?"; // It doesn't work if written as @lastname
            command.Parameters.Add("@lastname", OleDbType.WChar, 50);
            command.Parameters[0].Value = "Алексеев";

            OleDbDataReader reader = command.ExecuteReader();

            ShowInformationInListView(reader);

            connection.Close();
        }

        private void selectAllFromDBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = CreateConnection();

            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "Peoples";
            command.CommandType = CommandType.TableDirect;

            OleDbDataReader reader = command.ExecuteReader();

            ShowInformationInListView(reader);

            connection.Close();
        }

        void ShowInformationInListView(OleDbDataReader reader)
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            // Changing properties of listview
            listView1.View = View.Details;

            listView1.Columns.Add("Surname", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Name", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Birthday", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Sex", 30, HorizontalAlignment.Center);

            // Showing the result in listview
            while (reader.Read())
            {
                ListViewItem item =
                    listView1.Items.Add(reader["Фамилия"].ToString().TrimEnd());
                item.SubItems.Add(reader.GetValue(2).ToString().TrimEnd());
                item.SubItems.Add(reader.GetValue(3).ToString().TrimEnd());
                item.SubItems.Add(reader.GetValue(4).ToString().TrimEnd());
            }
        }
    }
}
