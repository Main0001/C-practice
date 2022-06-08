using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_3_доп_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 4;
            int[,] mas = new int[3, 4];
            int i, j;

            Random random = new Random();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    mas[i, j] = random.Next(10, 20);
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = mas[i, j].ToString();
                }
            }
            for (i = 0; i < 3; i++)
            {
                int min = 100;
                for (j = 0; j < 4; j++)
                {
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                    }
                }
                textBoxResult.Text += min.ToString() + Environment.NewLine;
            }
        }
    }
}
