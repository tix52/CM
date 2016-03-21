using CasierModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class ClientsViewModel: INotifyPropertyChanged
    {
        private ObservableCollection<Client> _clients;
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public ClientsViewModel()
        {
            _clients = new ObservableCollection<Client>();
            for(int i = 0; i < 5456; i++)
            {
                var tmp = new Client();
                tmp.IdClient = i;
                tmp.Nom = "aezae";
                tmp.Prenom = "hjdfg";
                _clients.Add(tmp);
            }

        }

        public ObservableCollection<Client> Clients
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
    }
}
