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

namespace Task2
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

    public class Shapes : FrameworkElement
    {
        SolidColorBrush brush = new SolidColorBrush(Colors.Black);
        private Pen mainPen = new Pen(Brushes.Black, 1.0);

        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawEllipse(null, mainPen, new Point(50, 50), 40, 40);
            drawingContext.DrawEllipse(null, mainPen, new Point(50, 50), 30, 30);
            drawingContext.DrawEllipse(null, mainPen, new Point(50, 50), 20, 20);

            drawingContext.DrawRectangle(null, mainPen, new Rect(100, 30, 40, 60));
            drawingContext.DrawRectangle(null, mainPen, new Rect(120, 70, 40, 60));
            drawingContext.DrawRectangle(null, mainPen, new Rect(140, 110, 40, 60));
            drawingContext.DrawRectangle(null, mainPen, new Rect(160, 150, 40, 60));
            drawingContext.DrawRectangle(null, mainPen, new Rect(180, 190, 40, 60));

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (((i % 2 == 0) && (j % 2 != 0)) || ((i % 2 != 0) && (j % 2 == 0)))
                        drawingContext.DrawRectangle(brush, mainPen, new Rect(20 * (j + 10), 20 * i, 20, 20));
                    else
                        drawingContext.DrawRectangle(null, mainPen, new Rect(20 * (j + 10), 20 * i, 20, 20));
                }
            }

            drawingContext.DrawEllipse(brush, mainPen, new Point(50, 150), 20, 20);
            drawingContext.DrawRectangle(brush, mainPen, new Rect(50, 200, 40, 60));
            drawingContext.DrawEllipse(null, mainPen, new Point(50, 300), 20, 20);

            drawingContext.DrawLine(mainPen, new Point(300, 350), new Point(350, 300));
            drawingContext.DrawLine(mainPen, new Point(350, 300), new Point(350, 400));
            drawingContext.DrawLine(mainPen, new Point(350, 400), new Point(300, 350));

            base.OnRender(drawingContext);
        }
    }
}