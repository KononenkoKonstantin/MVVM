using _02_Lesson2.Helpers;
using _02_Lesson2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _02_Lesson2.ViewModels
{
    public class BookViewModel : ViewModelBase
    {
        private Book _book;
        private RelayCommand _getCommand;
        private RelayCommand _giveCommand;

        public BookViewModel(Book book)
        {
            this._book = book;
        }

        public string Title
        {
            get { return this._book.Title; }
            set
            {
                if (this._book.Title != value)
                {
                    this._book.Title = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Author
        {
            get { return this._book.Author; }
            set
            {
                if (this._book.Author != value)
                {
                    this._book.Author = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int Count
        {
            get { return this._book.Count; }
            set
            {
                if (this._book.Count != value)
                {
                    this._book.Count = value;
                    RaisePropertyChanged();
                }
            }
        }

        #region Commands
        private void getItem(object p)
        {
            this.Count++;
        }

        public ICommand GetCommand
        {
            get
            {
                if (this._getCommand == null)
                    this._getCommand = new RelayCommand(this.getItem);
                return this._getCommand;
            }
        }

        private void giveItem(object p)
        {
            this.Count--;
        }

        private bool canGiveItem(object p)
        {
            return this.Count > 0;
        }

        public ICommand GiveCommand
        {
            get
            {
                if (this._giveCommand == null)
                    this._giveCommand = new RelayCommand(this.giveItem, this.canGiveItem);

                return this._giveCommand;
            }
        }
        #endregion
    }
}
