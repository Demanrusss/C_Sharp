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

namespace Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ReadData()
        {
            // Initialization of a connection
            OleDbConnection connection = CreateConnection();

            // Creating a request
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Peoples";

            // Executing the request
            OleDbDataReader reader = command.ExecuteReader();

            // Getting indexes of fields
            int surnameIndex = reader.GetOrdinal("Фамилия");
            int nameIndex = reader.GetOrdinal("Имя");
            int birthdayIndex = reader.GetOrdinal("ДатаРождения");
            int sexIndex = reader.GetOrdinal("Пол");

            listView1.View = View.Details;

            // Loop of reading data
            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add(reader["Фамилия"].ToString().TrimEnd());
                item.SubItems.Add(reader.GetValue(nameIndex).ToString().TrimEnd());
                item.SubItems.Add(reader.GetValue(birthdayIndex).ToString().TrimEnd());
                item.SubItems.Add(reader.GetValue(sexIndex).ToString().TrimEnd());
            }

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
                MessageBox.Show("There is a mistake while opening DB");

            }

            return connection;
        }

        private void readDBDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadData();
        }
    }
}
