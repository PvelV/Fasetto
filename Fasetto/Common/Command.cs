using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Common
{
    public class Command : ICommand
    {
        private Action actionParameterless;
        private Action<object> action;
        private Predicate<object> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            if (parameter == null)
            {
                actionParameterless();
            }
            else
            {
                action(parameter);
            }
        }

        public Command(Action<object> _action, Predicate<object>_canExecute = null)
        {
            action = _action;
            canExecute = _canExecute;// ?? new Predicate<object>((p) => { return true; });
        }
        public Command(Action _action, Predicate<object> _canExecute = null)
        {
            actionParameterless = _action;
            canExecute = _canExecute;// ?? new Predicate<object>((p) => { return true; });
        }
    }
}
