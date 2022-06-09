using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Additional2
{
    public partial class Form1 : Form
    {
        int[] arr = new int[15];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                arr[i] = rnd.Next(50) - 20;
                listBox1.Items.Add($"Mas[{i}] = {arr[i]}");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                if (arr[i] > 0)
                    listBox2.Items.Add($"Mas[{i}] = {arr[i] * arr[i]}");
                if (arr[i] < 0)
                    listBox2.Items.Add($"Mas[{i}] = {arr[i] * 2}");
            }
        }
    }
}
