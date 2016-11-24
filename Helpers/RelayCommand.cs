using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Input;

namespace _02_Lesson2.Helpers
{
    public class RelayCommand : ICommand
    {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            if (execute == null)
                throw new ArgumentException("Exeption!!!");
            this._execute = execute;
            this._canExecute = canExecute;
        }

        public bool CanExecute (object p)
        {
            return this._canExecute == null ? true : this._canExecute(p);
        }

        public void Execute (object p)
        {
            this._execute(p);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
