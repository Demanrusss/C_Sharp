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

namespace ResultReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = CreateConnection();

            OleDbCommand command = connection.CreateCommand();
            command.CommandText = 
                "INSERT INTO Peoples (Фамилия, Имя, ДатаРождения, Пол) " +
                "VALUES ('Сергеева', 'Валентина', '05.10.1971', 'Ж'); " +
                "DELETE FROM Peoples WHERE Фамилия = 'Петрова'" +
                "SELECT * FROM Peoples";

            OleDbDataReader reader = command.ExecuteReader();
            MessageBox.Show(reader.RecordsAffected.ToString());
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
    }
}
