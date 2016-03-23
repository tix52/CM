using System;
using System.Windows.Input;

namespace GUI.Client
{
    public class CommandHandler : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public virtual Action ActionToExecute { get; set; }
        public virtual Func<bool> CanExecutePredicate { get; set; }


        public CommandHandler(Action actionToExecute, Func<bool> canExecute)
        {
            if (actionToExecute == null) throw new ArgumentNullException("actionToExecute");
            CanExecutePredicate = canExecute;
            ActionToExecute = actionToExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (CanExecutePredicate == null) return true;
            return CanExecutePredicate();
        }

        public void Execute(object parameter)
        {
            ActionToExecute();
        }
    }
}
