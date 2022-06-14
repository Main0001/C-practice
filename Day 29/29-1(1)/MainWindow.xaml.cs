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

namespace _29_1_1_
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

        protected override void OnRender(DrawingContext drawingContext)
        {
            var triangle = new DrawingVisual();
            using (DrawingContext dc = triangle.RenderOpen())
            {
                var start = new Point(0, 50);

                var segments = new[]
                {
                  new LineSegment(new Point(50,0), true),
                  new LineSegment(new Point(50, 100), true)
                };

                var figure = new PathFigure(start, segments, true);
                var geo = new PathGeometry(new[] { figure });
                dc.DrawGeometry(Brushes.Red, null, geo);

                var drawingPen = new Pen(Brushes.Black, 3);
                dc.DrawLine(drawingPen, new Point(0, 50), new Point(50, 0));
                dc.DrawLine(drawingPen, new Point(50, 0), new Point(50, 100));
                dc.DrawLine(drawingPen, new Point(50, 100), new Point(0, 50));
            }
        }
    }
}