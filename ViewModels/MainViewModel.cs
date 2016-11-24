using _02_Lesson2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Lesson2.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<BookViewModel> Books { get; set; }

        public MainViewModel (List<Book> books)
        {
            this.Books = new ObservableCollection<BookViewModel>(books.Select(b => new BookViewModel(b)));
        }
    }
}
