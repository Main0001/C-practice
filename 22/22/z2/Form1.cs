using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = Convert.ToDouble(textBox3.Text);

                textBox4.Text = "Laboratory work 22, Task 2, Leonov A.A." + Environment.NewLine;
                textBox4.Text += "value X = " + textBox1.Text + Environment.NewLine;
                textBox4.Text += "value Y = " + textBox2.Text + Environment.NewLine;
                textBox4.Text += "value Z = " + textBox3.Text + Environment.NewLine;

                double r = Math.Max(Math.Min(Math.Pow(x, 2), y), z);
                textBox4.Text += "result is " + r.ToString() + Environment.NewLine;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured - {ex}");
            }
        }
    }
}
