using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Additonal3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 20;

            int[,] arr = new int[10, 20];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-20, 20);
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j].ToString();
                }
            dataGridView1.AutoResizeColumns();

            int[] arrPositive = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i,j] >= 0)
                        arrPositive[i]++;
            label1.Text = "Количество положительных элементов в каждой строке: " + string.Join(" ", arrPositive);
        }
    }
}
