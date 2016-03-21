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
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Casier> _casiers;
        
        private ObservableCollection<AffectationCasierClient> _affectations;

        public MainWindowViewModel()
        {
            _casiers = new ObservableCollection<Casier>();
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public ObservableCollection<Casier> Casiers
        {
            get
            {
                return _casiers;
            }

            set
            {
                _casiers = value;
                OnPropertyChanged();
            }
        }

      

        public ObservableCollection<AffectationCasierClient> Affectations
        {
            get
            {
                return _affectations;
            }

            set
            {
                _affectations = value;
                OnPropertyChanged();
            }
        }
    }
}
