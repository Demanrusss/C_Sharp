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

namespace DBConnectionProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=SQLOLEDB.1;
                Integrated Security=SSPI;Persist Security Info=False;
                Initial Catalog=TestDatabase;Data Source=localhost\SQLEXPRESS";
            
            // one way of working with DB
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("There is a mistake while connecting to DB");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            // Better way of working with DB
            using (connection)
            {
                connection.Open();

                // First method to get a responce
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM Peoples";
                int number = (int)command.ExecuteScalar();
                MessageBox.Show(number.ToString());

                // Second method to get a responce
                OleDbCommand command2 = 
                    new OleDbCommand("SELECT COUNT(*) FROM Peoples", connection);
                MessageBox.Show(command2.ExecuteScalar().ToString());
            }
        }
    }
}
