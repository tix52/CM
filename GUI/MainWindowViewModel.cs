using GUI.Client;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace GUI
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private ICommand _clientCommand;
        private ICommand _casierCommand;
        private ICommand _affectationsCommand;
        
        public MainWindowViewModel()
        {
            _clientCommand = new CommandHandler(ClientHandler, null);
            _casierCommand = new CommandHandler(CasierHandler, null);
            _affectationsCommand = new CommandHandler(AffectationHandler, null);

        }

        private void CasierHandler()
        {
        }

        private void ClientHandler()
        {
            
        }

        private void AffectationHandler()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ClientCommand
        {
            get
            {
                return _clientCommand;
            }
        }

        public ICommand CasierCommand
        {
            get
            {
                return _casierCommand;
            }
        }

        public ICommand AffectationsCommand
        {
            get
            {
                return _affectationsCommand;
            }

        }

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        
    }
}
