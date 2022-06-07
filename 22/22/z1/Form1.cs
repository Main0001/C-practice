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

        private void Form1_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = 2.444.ToString();
            textBox2.Text = (0.869 * Math.Pow(10, -2)).ToString();
            textBox3.Text = (-0.13 * Math.Pow(10, 3)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double constantE = 2.7182;
            textBox4.Text = "Laboratory work 22, Task 1, Leonov A.A.";
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double h = Math.Round((Math.Pow(x, y+1) + Math.Pow(constantE, y-1))/(1 + x * Math.Abs(y - Math.Tan(z))) * (1 + Math.Abs(y - x)) + (Math.Pow(Math.Abs(y - x), 2) / 2) - (Math.Pow(Math.Abs(y - x), 3) / 3), 4);
            textBox4.Text += Environment.NewLine +
            "Result h: " + h.ToString();
        }
    }
}
