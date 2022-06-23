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
        int[] arr = new int[30];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                arr[i] = rnd.Next(50) - 20;
                listBox1.Items.Add($"Mas[{i}] = {arr[i]}");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < 30; i++)
            {
                if (arr[i] % 5 == 0)
                    sum += arr[i];
            }
            listBox2.Items.Add($"Sum = {sum}");
        }
    }
}
