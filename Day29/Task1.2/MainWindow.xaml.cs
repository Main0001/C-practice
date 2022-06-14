using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class ZigZagLines : FrameworkElement
    {
        Point[] points = new Point[20];
        private Pen mainPen = new Pen(Brushes.Black, 2.0);

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            for (int i = 0; i < 20; i++)
            {
                int xPos;
                if (i % 2 == 0)
                    xPos = 10;
                else
                    xPos = 400;
                points[i] = new Point(xPos, 10 * i);
            }

            for (int i = 0; i < 20; i++)
            {
                if (i == 19)
                    drawingContext.DrawLine(mainPen, points[points.Length - 1], points[0]);
                else
                    drawingContext.DrawLine(mainPen, points[i], points[i + 1]);
            }
        }
    }
}
