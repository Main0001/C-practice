using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 4;
            int[,] matrix = new int[3, 4];
            int i, j;

            Random random = new Random();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    matrix[i, j] = random.Next(-6, 10);
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }
            for (i = 0; i < 3; i++)
            {
                int min = 100;
                for (j = 0; j < 4; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                textBoxResult.Text += min.ToString() + " - Min element in string" + Environment.NewLine;
            }
        }
    }
}
