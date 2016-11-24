using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using _02_Lesson2.View;
using _02_Lesson2.ViewModels;
using _02_Lesson2.Models;

namespace _02_Lesson2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            List<Book> b = new List<Book>()
            {
                new Book() {Title = "Война миров",  Author = "Герберт Уэлс",  Count = 1},
                new Book() {Title = "Пиковая дама", Author = "Александр Пушкин", Count = 1 },
                new Book() {Title = "Мцыри", Author = "Михаил Лермонтов", Count = 2 }
            };

            var MainView = new MainView();
            var MainViewModel = new MainViewModel(b);
            MainView.DataContext = MainViewModel;
            this.MainWindow = MainView;
            this.MainWindow.Show();
        }
    }
}
