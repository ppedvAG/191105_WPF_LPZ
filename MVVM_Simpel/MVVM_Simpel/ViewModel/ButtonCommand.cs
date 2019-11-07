using System;
using System.Windows.Input;

namespace MVVM_Simpel.ViewModel
{
    public class ButtonCommand : ICommand
    {
        public ButtonCommand(Action execute, Func<bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute ?? new Func<bool>(() => true); // Keine Validierung -> Alles ist erlaubt :)
        }

        private Action execute;
        private Func<bool> canExecute;
        
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // Validierung
            return canExecute();
        }

        public void Execute(object parameter)
        {
            // Logik ausführen
            execute();
        }
    }
}
