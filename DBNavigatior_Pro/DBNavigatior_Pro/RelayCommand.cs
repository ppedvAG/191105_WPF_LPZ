using System;
using System.Windows.Input;

namespace DBNavigatior_Pro
{
    public class RelayCommand : ICommand
    {
        // Quickactions+Refactoring/GenerateConstructor
        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute ?? new Func<bool>(() => true);
        }

        private Action execute;
        private Func<bool> canExecute;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return canExecute();
        }

        public void Execute(object parameter)
        {
            execute();
        }
    }
}
