using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CasierModel;

namespace GUI.Client
{
    class ClientsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<CasierModel.Client> _clients;
        public event PropertyChangedEventHandler PropertyChanged;
        private ICommand _saveCommand;
        private ICommand _deleteCommand;
        private CasierModel.Client _selectedItem;
        private HashSet<CasierModel.Client> _addedItems;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        private void SaveHandler()
        {

        }

        private void DeleteHandler()
        {

        }

        public ClientsViewModel()
        {
            _clients = new ObservableCollection<CasierModel.Client>();

            for (int i = 0; i < 10; i++)
            {
                var tmp = new CasierModel.Client();
                tmp.IdClient = i;
                tmp.Nom = "aezae";
                tmp.Prenom = "hjdfg";
                _clients.Add(tmp);
            }

            _saveCommand = new CommandHandler(SaveHandler, null);
            _deleteCommand = new CommandHandler(DeleteHandler, null);
            _addedItems = new HashSet<CasierModel.Client>();
        }

        public ObservableCollection<CasierModel.Client> Clients
        {
            get
            {
                return _clients;
            }

            set
            {
                _clients = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                return _saveCommand;
            }

            set
            {
                _saveCommand = value;
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return _deleteCommand;
            }

            set
            {
                _deleteCommand = value;
            }
        }

        public CasierModel.Client SelectedItem
        {
            get
            {
                return _selectedItem;
            }

            set
            {
                _selectedItem = value;
                if (_selectedItem != null && !_clients.Contains(_selectedItem)) _addedItems.Add(value);
                OnPropertyChanged();
            }
        }
    }
}
