using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MidSys
{
    public class DelegateCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            var can = canExecute?.Invoke((T)parameter) ?? true;
            if(can != canExecuteState)
            {
                canExecuteState = can;
                CanExecuteChanged?.Invoke(this, new EventArgs());
            }
            return can;
        }

        public void Execute(object parameter)
        {
            execute?.Invoke((T)parameter);
        }

        private readonly Predicate<T> canExecute = default;
        private readonly Action<T> execute = default;
        private bool canExecuteState = false;

        public DelegateCommand(Action<T> execute)
        {
            this.execute = execute;
        }

        public DelegateCommand(Action<T> execute, Predicate<T> canExecute) 
            : this(execute)
        {
            this.canExecute = canExecute;
        }
    }
}
