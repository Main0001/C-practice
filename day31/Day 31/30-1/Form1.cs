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
        private string dbPath =
            @"D:\Git projects\C-practice\day31\Day 31\30-1\DBTur_firm.mdf";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBTur_firmDataSet2.Туристы". При необходимости она может быть перемещена или удалена.
            this.туристыTableAdapter.Fill(this.dBTur_firmDataSet2.Туристы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBTur_firmDataSet1.Туры". При необходимости она может быть перемещена или удалена.
            this.турыTableAdapter.Fill(this.dBTur_firmDataSet1.Туры);
            sqlConnection = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};");
            sqlConnection.Open();

        }




        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            editTableForm editTableForm = new editTableForm();
            editTableForm.connection = sqlConnection;
            editTableForm.ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            var currentCeil = dataGridView1.SelectedCells;
            var id = dataGridView1[0, currentCeil[0].RowIndex].Value;
            string query = "DELETE FROM Туры "
                + $"WHERE Код_тура = {id}";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            editTableForm editTableForm = new editTableForm();
            editTableForm.connection = sqlConnection;
       

            var currentCeil = dataGridView2.SelectedCells;
            editTableForm.textBox1.Text = dataGridView2[1, currentCeil[0].RowIndex].Value.ToString();
            editTableForm.textBox2.Text = dataGridView2[2, currentCeil[0].RowIndex].Value.ToString();
            editTableForm.textBox3.Text = dataGridView2[3, currentCeil[0].RowIndex].Value.ToString() ;
            editTableForm.type = "edit";
            editTableForm.id = dataGridView2[0, currentCeil[0].RowIndex].Value.ToString();
            editTableForm.ShowDialog();
        }
    }
}
