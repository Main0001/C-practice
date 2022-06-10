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

namespace z1_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ButtonRun.Click += ButtonRun_Click_1;
            ButtonAbout.Click += ButtonAbout_Click;
        }

        private void ButtonRun_Click_1(object sender, RoutedEventArgs e)
        {
            String hello = "Hello, ";
            String input = string.Empty;
            if (string.IsNullOrEmpty(TextBoxEnterName.Text) || string.IsNullOrWhiteSpace(TextBoxEnterName.Text))
            {
                input = "World!";
            }
            else
            {
                input = TextBoxEnterName.Text;
            }
            TextBlockHello.Text = $"{hello} {input}";
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            string info = $"About program{this.Title}";
            AboutApp aboutApp = new AboutApp(info);
            aboutApp.ShowDialog();
        }
    }
}
