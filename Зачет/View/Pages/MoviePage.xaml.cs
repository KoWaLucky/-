using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Зачет.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MoviePage.xaml
    /// </summary>
    public partial class MoviePage : Page
    {
        public MoviePage()
        {
            InitializeComponent();
            List<Product> product = new List<Product>();
            
                product.Add(new Product() { Id = 1, Name = "Движение вверх", CreatedDate = new DateTime(2022 - 10 - 22), Price = 200m });
                product.Add(new Product() { Id = 2, Name = "Formula 1", CreatedDate = new DateTime(2022 - 12 - 22),Price = 800m });
            ProductLv.ItemsSource = product;

        }
    }
}
