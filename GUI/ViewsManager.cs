using GUI.Client;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace GUI
{
    public class ViewsManager
    {
        private static Lazy<ViewsManager> _instance = new Lazy<ViewsManager>(() => new ViewsManager());
        private ViewsManager()
        {
            views = new Dictionary<string, UserControl>(3);
            clientKey = typeof(ClientsView).Name;
            //  casierKey = typeof(ClientsView).Name;
            // affectationKey = typeof(ClientsView).Name;

        }

        public static ViewsManager Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        Dictionary<string, UserControl> views;
        string clientKey;
        string casierKey;
        string affectationKey;

        public void CreateAndOpenClientView()
        {
            UserControl clientView;
            if (!views.TryGetValue(clientKey, out clientView))
            {
                clientView = new ClientsView();
                views.Add(clientKey, clientView);
            }
            var window = new Window();
            window.Content = clientView;
            window.Show();
        }
    }
}
