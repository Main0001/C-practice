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
                double MinX = double.Parse(textBoxXmin.Text);
                double MaxX = double.Parse(textBoxXmax.Text);
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double Step = double.Parse(textBoxStep.Text);

                int count = (int)Math.Ceiling((MaxX - MinX) / Step) + 1;
                double[] x = new double[count];
                double[] y1 = new double[count];

                for (int i = 0; i < count; i++)
                {
                    x[i] = MinX + Step * i;
                    y1[i] = Math.Pow(Math.Sin(x[i]), 2);
                }

                chart1.ChartAreas[0].AxisX.Minimum = MinX;
                chart1.ChartAreas[0].AxisX.Maximum = MaxX;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
                chart1.Series[0].Points.DataBindXY(x, y1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured - {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
