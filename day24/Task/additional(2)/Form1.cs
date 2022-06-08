using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace additional_2_
{
    public partial class Form1 : Form
    {
        private int[] mas = new int[20];
        private int max = 0;
        private int maxIndex;
        private int temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArr_Click(object sender, EventArgs e)
        {
            listBoxArr.Items.Clear();
            // Инициализируем класс случайных чисел
            Random rand = new Random();
            // Генерируем и выводим 15 элементов
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(-50, 50);
                listBoxArr.Items.Add("Mas[" + i.ToString() + "] = " + mas[i].ToString());
            }
        }
        private void buttonArrResult_Click(object sender, EventArgs e)
        {
            listBoxArrResult.Items.Clear();
            for (int i = 0;i < mas.Length; i++)
            {
                if (max < mas[i])
                {
                    max = mas[i];
                    maxIndex = i;
                }
            }

            temp = mas[0];
            mas[0] = max;
            mas[maxIndex] = temp;

            for (int i = 0; i < mas.Length; i++)
            {
                listBoxArrResult.Items.Add("Mas[" + i.ToString() + "] = " + mas[i].ToString());
            }
        }
    }
}
