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
            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount = 3;

            int[,] arr = new int[4, 3];
            Random rnd = new Random();
            int maxValue = int.MinValue;

            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-20, 20);
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j].ToString();
                }
            dataGridView1.AutoResizeColumns();

            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i,j] > maxValue)
                        maxValue = arr[i,j];
            label1.Text = "Максимальный элемент: " + string.Join(" ", maxValue);
        }
    }
}
