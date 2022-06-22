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

namespace DataGridViewProject2
{
    public partial class Form1 : Form
    {
        private DataSet _dataSet = new DataSet();
        private BindingSource _bindingSource = new BindingSource();

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
                MessageBox.Show("There is a mistake while opening DB");
            }

            return connection;
        }

        private void readDataFromDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = CreateConnection();

            OleDbDataAdapter adapter = new OleDbDataAdapter(
                @"SELECT * 
                  FROM Peoples p 
                    INNER JOIN Address a ON p.idKey = a.idPeopleKey", 
                connection);

            adapter.Fill(_dataSet);

            connection.Close();

            dataGridView1.AutoGenerateColumns = true;
            _bindingSource.DataSource = _dataSet.Tables[0];
            dataGridView1.DataSource = _bindingSource;
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = CreateConnection();

            OleDbDataAdapter adapter = new OleDbDataAdapter(
                @"SELECT * 
                  FROM Peoples p 
                    INNER JOIN Address a ON p.idKey = a.idPeopleKey",
                connection);

            adapter.UpdateCommand = new OleDbCommand(
                @"UPDATE Peoples
                  SET Фамилия = ?, Имя = ?, Пол = ? 
                  WHERE idKey = ?; 
                  UPDATE Address 
                  SET Адрес = ? 
                  WHERE idAddressKey = ?"
            );

            // Creating parameters
            adapter.UpdateCommand.Parameters.Add("Фамилия", 
                OleDbType.WChar, 50, "Фамилия");
            adapter.UpdateCommand.Parameters.Add("Имя",
                OleDbType.WChar, 50, "Имя");
            adapter.UpdateCommand.Parameters.Add("Пол",
                OleDbType.WChar, 50, "Пол");
            adapter.UpdateCommand.Parameters.Add("idKey",
                OleDbType.Integer, 10, "idKey");
            adapter.UpdateCommand.Parameters.Add("Адрес",
                OleDbType.WChar, 50, "Адрес");
            adapter.UpdateCommand.Parameters.Add("idAddressKey",
                OleDbType.Integer, 50, "idAddressKey");

            adapter.UpdateCommand.Connection = connection;

            adapter.Update(_dataSet.Tables[0]);

            connection.Close();
        }
    }
}
