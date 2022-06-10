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
                double x = double.Parse(txX.Text);
                double xMin = double.Parse(textboxXmin.Text);
                double xMax = double.Parse(Xmax.Text);
                double step = double.Parse(Step.Text);
                Values1 = FunctionGraph(xMin, xMax, step, x);
                DataContext = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured - {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private ChartValues<double> FunctionGraph(double xMin, double xMax, double step, double x)
        {
            ChartValues<double> values = new ChartValues<double>();
            for (double i = xMin; i <= xMax; i += step)
            {
                double result = Math.Pow(Math.Sin(i),2);
                values.Add(result);
            }
            return values;
        }
    }
}
