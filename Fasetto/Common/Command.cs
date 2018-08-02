using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Common
{
    public class Command<T> : ICommand
    {
        private Action<T> action;
        private Predicate<T> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            action((T)parameter);
        }

        public Command(Action<T> _action, Predicate<T>_canExecute=null)
        {
            action = _action;
            canExecute = _canExecute;
        }
    }
}
