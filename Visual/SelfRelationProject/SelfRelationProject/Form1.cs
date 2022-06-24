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

namespace SelfRelationProject
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
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Positions";
            command.Connection = connection;

            // Copying the result to dataset
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            _dataset = new DataSet();
            adapter.Fill(_dataset);
            connection.Close();

            // Making connections
            DataRelation relation = new DataRelation("Position",
                _dataset.Tables[0].Columns[0],
                _dataset.Tables[0].Columns[1]);
            _dataset.Relations.Add(relation);

            // Looking for zero position
            foreach (DataRow row in _dataset.Tables[0].Rows)
            {
                if (row.IsNull(1))
                    AddTreenode(row, null);
                else
                    break;
            }

            _dataset.Tables[0].Columns.Add("Quantity of employees",
                typeof(int), "COUNT(Child.idPosition)");
            dataGridView1.DataSource = _dataset.Tables[0];

            foreach (Constraint c in _dataset.Tables[0].Constraints)
                if (c is ForeignKeyConstraint)
                {
                    ((ForeignKeyConstraint)c).DeleteRule = Rule.None;
                    ((ForeignKeyConstraint)c).UpdateRule = Rule.None;
                }
        }

        private void AddTreenode(DataRow row, TreeNode node)
        {
            TreeNode currnode;
            if (node == null)
                currnode = treeView1.Nodes.Add(row.ItemArray[2].ToString());
            else
                currnode = node.Nodes.Add(row.ItemArray[2].ToString());

            foreach (DataRow currrow in row.GetChildRows("Position"))
                AddTreenode(currrow, currnode);
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
    }
}
