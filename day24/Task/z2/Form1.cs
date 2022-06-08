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
                double Xmin = double.Parse(textBoxXmin.Text);
                double Xmax = double.Parse(textBoxXmax.Text);
                double Step = double.Parse(textBoxStep.Text);
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                // Количество точек графика
                int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
                // Массив значений X – общий для обоих графиков
                double[] x = new double[count];
                // Два массива Y – по одному для каждого графика
                double[] y1 = new double[count];
                // Расчитываем точки для графиков функции
                for (int i = 0; i < count; i++)
                {
                    // Вычисляем значение X
                    x[i] = Xmin + Step * i;
                    // Вычисляем значение функций в точке X
                    y1[i] = (a * x[i]) + b;
                }
                // Настраиваем оси графика
                chart1.ChartAreas[0].AxisX.Minimum = Xmin;
                chart1.ChartAreas[0].AxisX.Maximum = Xmax;
                // Определяем шаг сетки
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

                // Добавляем вычисленные значения в графики
                chart1.Series[0].Points.DataBindXY(x, y1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
