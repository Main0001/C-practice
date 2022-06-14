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

namespace TaskExample
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

    public class HorizontalLines : FrameworkElement
    {
        private Pen mainPen = new Pen(Brushes.Black, 2.0);
        private double startPoint = 0.0;
        private double endPoint = 800.0;

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            for (int i = 0; i < 100; i++)
                drawingContext.DrawLine(mainPen, new Point(startPoint, i * 4 + 10), new Point(endPoint, i * 4 + 10));

        }
    }
}
