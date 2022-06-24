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

namespace DataRelationProject
{
    public partial class Form1 : Form
    {
        private DataSet _dataset;

        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        private void ReadData()
        {
            OleDbConnection connection = CreateConnection();

            // Creating command object
            OleDbCommand command = connection.CreateCommand();
            command.CommandText =
                "SELECT * FROM Peoples; " +
                "SELECT * FROM Address;";
            command.Connection = connection;

            // Creating an adapter and copy everything there
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            _dataset = new DataSet();
            adapter.Fill(_dataset);
            connection.Close();

            // Creating a relation
            DataRelation relation = new DataRelation("People_Address",
                _dataset.Tables[0].Columns[0],
                _dataset.Tables[1].Columns[1]);
            _dataset.Relations.Add(relation);

            // Binding tables to gridview
            peopleDataGridView.DataSource = _dataset.Tables[0];
            addressDataGridView.DataSource = _dataset.Tables[1];
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

        private void findAddressButton_Click(object sender, EventArgs e)
        {
            int index = peopleDataGridView.CurrentRow.Index;

            foreach (DataRow childRow in
                _dataset.Tables[0].Rows[index].GetChildRows("People_Address"))
                MessageBox.Show(childRow.ItemArray[2].ToString());
        }

        private void findPersonButton_Click(object sender, EventArgs e)
        {
            int index = addressDataGridView.CurrentRow.Index;

            DataRow row = 
                _dataset.Tables[1].Rows[index].GetParentRow("People_Address");
            MessageBox.Show(row.ItemArray[1].ToString());
        }

        private void showConstraintsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_dataset.Tables[0].Constraints.Count.ToString());

            UniqueConstraint unique = 
                (UniqueConstraint)_dataset.Tables[0].Constraints[0];
            MessageBox.Show(unique.Columns[0].Caption);

            ForeignKeyConstraint foreignKey =
                (ForeignKeyConstraint)_dataset.Tables[1].Constraints[0];
            MessageBox.Show(foreignKey.Columns[0].Caption);
        }
    }
}
