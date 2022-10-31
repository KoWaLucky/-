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

namespace Зачет.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для NewsPage.xaml
    /// </summary>
    public partial class NewsPage : Page
    {
        public NewsPage()
        {
            InitializeComponent();
            List<News> newslist = new List<News>()
            {
                new News() {Title = "ГЕНА УМЕР", Information = "Генадий стал крокодилом", Date= new DateTime(2022, 10, 25), Uri = new Uri(@"C:\Users\NiceCookMan\source\repos\Зачет\Зачет\Resources\Images\Krocodil.jpg")},
                new News() {Title = "Собака-король", Information = "Пес и его верные животные", Date= new DateTime(2022, 10, 25), Uri = new Uri(@"C:\Users\NiceCookMan\source\repos\Зачет\Зачет\Resources\Images\Pes.jpg")}
            };
            foreach (News news in newslist)
            {
                NewsLb.Items.Add(news);
            }
        }

        private void AddNewsBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
