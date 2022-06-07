using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_3
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
                textBoxResult.ScrollBars = ScrollBars.Vertical;
                var x0 = double.Parse(textBoxX0.Text);
                var x = x0;
                var xK = double.Parse(textBoxXk.Text);
                var dX = double.Parse(textBoxDx.Text);
                var d = double.Parse(textBoxB.Text);

                for (double i = x0; i <= xK; i += d)
                {
                    result = Math.Pow(x, 4) + Math.Cos(2 + Math.Pow(x, 3) - dX);
                    textBoxResult.Text += Convert.ToString(result) + Environment.NewLine;
                    x += dX;
                }
        }
    }
}
