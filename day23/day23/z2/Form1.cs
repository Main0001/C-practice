using System;
using System.Windows.Forms;

namespace z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculateResult_Click(object sender, EventArgs e)
        {
            double result = default(double);
            try
            {
                var x = double.Parse(textBoxX.Text);
                var y = double.Parse(textBoxY.Text);
                if (x * y > 0)
                {
                    result = Math.Pow((Math.Pow(x, 2) + y), 2) - Math.Sqrt(Math.Pow(x, 2) * y);
                }
                else if (x * y < 0)
                {
                    result = Math.Pow((Math.Pow(x, 2) + y), 2) + Math.Sqrt(Math.Abs(Math.Pow(x, 2) * y));
                }
                else
                {
                    result = Math.Pow((Math.Pow(x, 2) + y), 2) + 1;
                }
                textBoxResult.Text = "Мушинский Максим Cергеевич;День 23;Задание 2;";
                textBoxResult.Text += Environment.NewLine + "Result: " + result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearValues_Click(object sender, EventArgs e)
        {
            textBoxX.Text = null;
            textBoxY.Text = null;
            textBoxResult.Text = null;
        }
    }
}
