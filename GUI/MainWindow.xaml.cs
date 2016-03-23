﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        //     this.Loaded += MainWindow_Loaded;
          //  UIPanel.Children.Add(new Client.ClientsView());
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var factory = RibbonFactory.Instance;
            factory.AddRibbonTab();
        }
    }
}
