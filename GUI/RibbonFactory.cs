
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Media;

namespace GUI
{
    public class RibbonFactory
    {
        private readonly static Lazy<RibbonFactory> _instance = new Lazy<RibbonFactory>(() => new RibbonFactory());
        private MainWindow _mainWindow;
        public static RibbonFactory Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private RibbonFactory()
        {
           _mainWindow =  App.Current.MainWindow as MainWindow;
        }

        public void AddRibbonTab()
        {
            var w = new UserControl();
            
            w.Background = Brushes.Red;
            
            _mainWindow.UIPanel.Children.Add(w);
        }
    }
}
