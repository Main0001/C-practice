using System;
using System.Windows.Forms;

namespace _23_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculateResult_Click(object sender, EventArgs e)
        {     
            double x = double.Parse(textBoxX.Text);
            double y = double.Parse(textBoxY.Text);
            double z = double.Parse(textBoxZ.Text);
            double t = ((2 * Math.Cos(x - (Math.PI / 6))) / (0.5 * Math.Pow(Math.Sin(y), 2))) * (1 + ((Math.Pow(z, 2)) / (3 - (Math.Pow(z, 2) / 5))));
            textBoxResult.Text = "Gerasimchik Maksim Dmitrievich;Day 23;Ex 1;";
            textBoxResult.Text += Environment.NewLine + "Result t: " + Convert.ToString(t);
        }
    }
}
