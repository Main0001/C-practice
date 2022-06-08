using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = (16.55 * Math.Pow(10,-3)).ToString();
            textBox2.Text = (-2.75).ToString();
            textBox3.Text = 0.15.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Laboratory work 23, Task 9";
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double B = Math.Round(Math.Sqrt(10 * (Math.Pow(Math.Sqrt(x), 1/3) + Math.Pow(x, y+2))) * (Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y)), 4);
            textBox4.Text += Environment.NewLine +
            "Result w: " + B.ToString();
        }
    }
}
