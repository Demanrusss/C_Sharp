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

namespace Procedure
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
            connection.ConnectionString = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;
                Persist Security Info=False;Initial Catalog=TestDatabase;
                Data Source=localhost\SQLEXPRESS";

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Something went wrong while opening DB");
            }

            return connection;
        }

        void ReadData()
        {
            OleDbConnection connection = CreateConnection();

            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "GetPerson";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@lastname", OleDbType.WChar, 50);
            command.Parameters[0].Value = "Смирнов";

            OleDbDataReader reader = command.ExecuteReader();

            // Chenging properties if listView1
            listView1.View = View.Details;

            listView1.Columns.Add("Surname", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Name", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Birthday", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Sex", 30, HorizontalAlignment.Center);

            // Reading data row by row
            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add(reader["Фамилия"].ToString().TrimEnd());
                item.SubItems.Add(reader.GetValue(2).ToString().TrimEnd());
                item.SubItems.Add(reader.GetValue(3).ToString().TrimEnd());
                item.SubItems.Add(reader.GetValue(4).ToString().TrimEnd());
            }

            connection.Close();
        }

        private void readDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        private void getFuncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = CreateConnection();

            // Creating a command for procedure
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "GetNameFunc";
            command.CommandType = CommandType.StoredProcedure;

            // Creating output parameter
            command.Parameters.Add("@retvalue", OleDbType.WChar, 50);
            command.Parameters[0].Direction = ParameterDirection.ReturnValue;

            // Initialization of the input parameter value and its direction
            command.Parameters.Add("@lastname", OleDbType.WChar, 50);
            command.Parameters[1].Value = "Смирнов";
            command.Parameters[1].Direction = ParameterDirection.Input;

            // Executing a request
            command.ExecuteNonQuery();

            MessageBox.Show(command.Parameters[0].Value.ToString().TrimEnd());
        }

        private void getNameFuncByReqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = CreateConnection();

            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "{? = call GetNameFunc(?)}";

            command.Parameters.Add("@return", OleDbType.WChar, 50);
            command.Parameters.Add("@lastname", OleDbType.WChar, 50);

            command.Parameters[0].Direction = ParameterDirection.ReturnValue;
            command.Parameters[1].Value = "Смирнов";
            command.Parameters[1].Direction = ParameterDirection.Input;

            command.ExecuteScalar();
            MessageBox.Show(command.Parameters[0].Value.ToString().TrimEnd());
        }
    }
}
