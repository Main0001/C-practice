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

namespace z1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random Random = new Random();
        private int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = new Button();
            btn.MouseEnter += MouseEnter;
            btn.Click += Button_Click;
            btn.Content = "Дочерняя кнопка " + Convert.ToString(count);
            btn.Margin = new Thickness(Random.Next(0, 430), Random.Next(0, 400), Random.Next(0, 430), Random.Next(0, 500));
            form1.Children.Add(btn);
            count++;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            form1.Children.Remove(button);
        }

        private void MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = new Button();
            button.MouseEnter += MouseEnter;
            button.Click += Button_Click;
            button.Content = "Дочерняя кнопка дочерней кнопки";
            button.Margin = new Thickness(Random.Next(0, 430), Random.Next(0, 400), Random.Next(0, 430), Random.Next(0, 500));
            form1.Children.Add(button);
        }
    }
}
