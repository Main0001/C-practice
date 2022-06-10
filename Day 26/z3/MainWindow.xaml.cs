using System;
using System.Windows;
using LiveCharts;
using LiveCharts.Wpf;
namespace z2
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


        public ChartValues<double> Values1 { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double xMin = double.Parse(textboxXmin.Text);
                double xMax = double.Parse(Xmax.Text);
                double step = double.Parse(Step.Text);
                double a = double.Parse(tbA.Text);
                double b = double.Parse(tbB.Text);
                Values1 = GetArr(xMin, xMax, step, a, b);
                DataContext = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private ChartValues<double> GetArr(double xMin, double xMax, double step, double a, double b)
        {
            ChartValues<double> cv1 = new ChartValues<double>();
            for (double i = xMin; i <= xMax; i += step)
            {
                double result = a * i + b;
                cv1.Add(result);

            }
            return cv1;
        }
    }
}
