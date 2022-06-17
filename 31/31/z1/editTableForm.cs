using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace _30_1
{
    public partial class EditTable : Form
    {
        public SqlConnection connection = null;
        public string type = "";
        public string identifier = "";
        public EditTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == "edit")
            {
                Form1 form1 = new Form1();
                string name = textBox1.Text;
                string surname = textBox2.Text;
                string patronymic = textBox3.Text;

                string query = "Update  Туристы " +
                    $"SET Имя='{name}', Фамилия='{surname}', Отчество='{patronymic}' " +
                    $"WHERE Код_туриста = {identifier}";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                this.Close();
                type = "";
            } else
            {
                Form1 form1 = new Form1();
                string name = textBox1.Text;
                string surname = textBox2.Text;
                string patronymic = textBox3.Text;

                string query = "Insert Into Туристы " +
                    $"(Имя, Фамилия, Отчество) Values('{name}', '{surname}', '{patronymic}')";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                this.Close();
            }

        }
    }
}
