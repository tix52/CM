using System.Windows.Controls;

namespace GUI.Client
{
    /// <summary>
    /// Logique d'interaction pour ClientView.xaml
    /// </summary>
    public partial class ClientsView : UserControl
    {
        public ClientsView()
        {
            InitializeComponent();
            DataContext = new ClientsViewModel();
        }
    }
}
