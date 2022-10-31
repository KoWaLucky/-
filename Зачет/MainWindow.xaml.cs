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
using Зачет.AppData;
using Зачет.View.Windows;

namespace Зачет
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

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            Users users = new Users();
            if (!string.IsNullOrWhiteSpace(LoginTb.Text) && !string.IsNullOrWhiteSpace(PasswordPb.Password))
            {
                MessageBox.Show("Добро пожаловать!");
                StartWindow startWindow = new StartWindow();
                startWindow.Show();
                Close();

            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }
    }
}
