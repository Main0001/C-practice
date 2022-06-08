using System;
using System.Windows.Forms;

namespace z3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculateResult_Click(object sender, EventArgs e)
        {

            double result;
            try
            {
                textBoxResult.ScrollBars = ScrollBars.Vertical;
                var x0 = double.Parse(textBoxX0.Text);
                var x = x0;
                var xK = double.Parse(textBoxXk.Text);
                var dX = double.Parse(textBoxDx.Text);
                var b = double.Parse(textBoxB.Text);

                for (double i = x0; i <= xK; i += dX)
                {
                    result = 15.28 * Math.Pow(Math.Abs(x), -(3 / 2)) + Math.Cos(Math.Log10(x) + b);
                    textBoxResult.Text += Convert.ToString(result) + Environment.NewLine;
                    x += dX;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
