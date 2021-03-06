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

namespace DataGridViewProject
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private DataSet dataset = new DataSet();

        public Form1()
        {
            InitializeComponent();

            ReadData();
        }

        private void ReadData()
        {
            // Connecting to a server
            OleDbConnection connection = CreateConnection();

            // Preparing for a command
            OleDbCommand command = new OleDbCommand("SELECT * FROM Peoples");
            command.Connection = connection;

            // Creating adapter and set of data
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            // Fill in the data set
            adapter.Fill(dataset);

            // Closing the connection
            connection.Close();

            // Binding dataset with grid through a mediator
            dataGridView1.AutoGenerateColumns = true;
            bindingSource.DataSource = dataset.Tables[0];
            dataGridView1.DataSource = bindingSource;
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

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = CreateConnection();
            OleDbDataAdapter adapter = 
                new OleDbDataAdapter("SELECT * FROM Peoples", connection);

            // Creating command objects
            adapter.UpdateCommand = new OleDbCommand(
                "UPDATE Peoples SET Фамилия = ?, Имя = ?, Пол = ? " +
                "WHERE idKey = ?");

            // Creating command parameters
            adapter.UpdateCommand.Parameters.Add("Фамилия", OleDbType.WChar, 50, 
                "Фамилия");
            adapter.UpdateCommand.Parameters.Add("Имя", OleDbType.WChar, 50, 
                "Имя");
            adapter.UpdateCommand.Parameters.Add("Пол", OleDbType.WChar, 50, 
                "Пол");
            adapter.UpdateCommand.Parameters.Add("idKey", OleDbType.Integer, 10, 
                "idKey");

            // Pointing to connection object
            adapter.UpdateCommand.Connection = connection;

            // Creating command objects for inserting
            adapter.InsertCommand = new OleDbCommand(
                @"INSERT INTO Peoples (Фамилия, Имя, ДатаРождения, Пол) 
                  VALUES (?, ?, ?, ?)");

            // Creating command parameters
            adapter.InsertCommand.Parameters.Add("Фамилия", OleDbType.VarChar, 50, 
                "Фамилия");
            adapter.InsertCommand.Parameters.Add("Имя", OleDbType.VarChar, 50,
                "Имя");
            adapter.InsertCommand.Parameters.Add("ДатаРождения", OleDbType.Date, 0,
                "ДатаРождения");
            adapter.InsertCommand.Parameters.Add("Пол", OleDbType.VarChar, 50,
                "Пол");

            adapter.InsertCommand.Connection = connection;

            // Creating command objects for deleting
            adapter.DeleteCommand = new OleDbCommand(
                @"DELETE FROM Peoples
                  WHERE idKey = ?");

            // Creating command parameters
            adapter.DeleteCommand.Parameters.Add("IdKey", OleDbType.Integer, 10, "idKey");

            adapter.DeleteCommand.Connection = connection;

            // Calling for data update
            adapter.Update(dataset.Tables[0]);

            connection.Close();
        }
    }
}
