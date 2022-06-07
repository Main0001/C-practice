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
            try
            {
                //textBoxX.Text = "14,26";
                double x = double.Parse(textBoxX.Text);
                //textBoxY.Text = "-1,22";
                double y = double.Parse(textBoxY.Text);
                //textBoxZ.Text = "0,035";
                double z = double.Parse(textBoxZ.Text);
                double t = ((2 * Math.Cos(x - (Math.PI / 6))) / (0.5 * Math.Pow(Math.Sin(y), 2))) * (1 + ((Math.Pow(z, 2)) / (3 - (Math.Pow(z, 2) / 5))));
                textBoxResult.Text = "Талерчик Алексей Cергеевич;День 23;Задание 1;";
                textBoxResult.Text += Environment.NewLine + "Result t: " + Convert.ToString(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
