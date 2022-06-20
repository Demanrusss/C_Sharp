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

namespace Transaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quantityOfRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating a connection
            OleDbConnection connection = CreateConnection();

            // Creating a command
            OleDbCommand command = connection.CreateCommand();
            command.CommandText =
                "SELECT COUNT(*) FROM Peoples";

            MessageBox.Show($"Quantity of records: {command.ExecuteScalar()}");

            // Closing a connection
            connection.Close();
        }

        private OleDbConnection CreateConnection()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString =
                @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;
                Initial Catalog=TestDatabase;Data Source=localhost\SQLEXPRESS";
            try
            {
                connection.Open();
                MessageBox.Show("Connection opened");
            }
            catch
            {
                MessageBox.Show("There is a mistake while opening the DB");
            }

            return connection;
        }

        private void insertRollbackTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating a connection
            OleDbConnection connection = CreateConnection();

            // Creating a command
            OleDbCommand command = connection.CreateCommand();
            command.CommandText =
                "INSERT INTO Peoples (Фамилия, Имя, ДатаРождения, Пол) " +
                "VALUES ('Иванова', 'Елена', '01.05.1971', 'Ж')";

            // Creating a transaction
            OleDbTransaction transaction = connection.BeginTransaction();

            // Binding the command with the transaction and run it
            command.Transaction = transaction;
            int rows = command.ExecuteNonQuery();

            // Rollback the transaction
            transaction.Rollback();

            // Closing the connection
            connection.Close();

            MessageBox.Show($"Might have been inserted {rows} rows, " +
                $"but transaction was canceled");
        }
    }
}
