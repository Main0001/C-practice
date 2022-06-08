using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[ind];
            int leng = str.Length;
            int OneAmount = 0;
            int ZeroAmount = 0;
            int i = 0;

            while (i < leng)
            {
                if (str[i] == '1')
                {
                    OneAmount += 1;
                }
                else if (str[i] == '0')
                {
                    ZeroAmount += 1;
                }
                i += 1;
            }
            labelOnes.Text = $"Counting 1: {Convert.ToString(OneAmount)}";
            labelZeros.Text = $"Counting 0: {Convert.ToString(ZeroAmount)}";
        }
    }
}
