using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.ScrollBars = ScrollBars.Vertical; 
            try
            {
                double x0 = Convert.ToDouble(textBox1.Text);
                double xk = Convert.ToDouble(textBox2.Text);
                double dx = Convert.ToDouble(textBox3.Text);
                double b = Convert.ToDouble(textBox4.Text);
                textBox5.Text = "Task 3 done by Leonov A.A. " + Environment.NewLine;
                double x = x0;
                for (double i = x0; i<=xk; i+=dx)
                {
                    double y = Math.Round(Math.Pow(10, -3) * Math.Round(Math.Abs(x), 5 / 2) + Math.Log10(Math.Abs(x + b)), 4);
                    textBox5.Text += "x=" + Convert.ToString(x) + "; y=" + Convert.ToString(y) + Environment.NewLine;
                    x += dx;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured - {ex}");
            }
        }
    }
}
