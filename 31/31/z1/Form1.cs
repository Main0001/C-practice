using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_1
{
    public partial class Form1 : Form
    {

        public SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        private string pathToDB = @"G:\Колледж\Git\C-practice\31\31\z1\DBTur_firm.mdf";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.турыTableAdapter.Fill(this.dBTur_firmDataSet1.Туры);
            this.туристыTableAdapter.Fill(this.dBTur_firmDataSet2.Туристы);
            sqlConnection = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={pathToDB};");
            sqlConnection.Open();

        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            EditTable editTable = new EditTable();
            editTable.connection = sqlConnection;
            editTable.ShowDialog();
        }
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            var currentCell = dataGridView1.SelectedCells;
            var identifier = dataGridView1[0, currentCell[0].RowIndex].Value;
            string query = "DELETE FROM Туры "
                + $"WHERE Код_тура = {identifier}";

            SqlCommand comand = new SqlCommand(query, sqlConnection);
            comand.ExecuteNonQuery();
        }
        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            EditTable editTable = new EditTable();
            editTable.connection = sqlConnection;
       

            var currentCell = dataGridView2.SelectedCells;
            editTable.textBox1.Text = dataGridView2[1, currentCell[0].RowIndex].Value.ToString();
            editTable.textBox2.Text = dataGridView2[2, currentCell[0].RowIndex].Value.ToString();
            editTable.textBox3.Text = dataGridView2[3, currentCell[0].RowIndex].Value.ToString() ;
            editTable.type = "edit";
            editTable.identifier = dataGridView2[0, currentCell[0].RowIndex].Value.ToString();
            editTable.ShowDialog();
        }
    }
}
