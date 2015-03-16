using System;
using System.Windows.Input;

namespace Tracker.Commands
{
    public class ButtonCommand : ICommand
    {
        Action<object> _whatToExecute;
        Func<object, bool> _whenToExecute;

        public ButtonCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this._whatToExecute = execute;
            this._whenToExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            bool result = false;

            if (_whenToExecute != null)
            {
                result = this._whenToExecute(parameter);
            }

            return result;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            this._whatToExecute(parameter);
        }
    }
}
