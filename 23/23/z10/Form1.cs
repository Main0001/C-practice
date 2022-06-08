using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z10
{
    public partial class Form1 : Form
    {
        private int[] Mas = new int[20];
        private int min = 99;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBoxArr.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = rnd.Next(-33, 66);
                listBoxArr.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBoxArrResult.Items.Clear();
            for (int i = 0; i < Mas.Length; i++)
            {
                if (min > Mas[i])
                {
                    min = Mas[i];
                }
            }
                listBoxArrResult.Items.Add(min.ToString());
        }
    }
}
