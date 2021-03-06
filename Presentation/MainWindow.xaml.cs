﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentation
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static Panel panel;

        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            panel = activePanel;
            activePanel.Visibility = Visibility.Visible;
            ChangePanel(new StartPage());         
        }

        public static Panel Panel { get { return panel; } set { panel = value; } }

        public static void ChangePanel(UserControl u)
        {
            panel.Children.Clear();
            panel.Children.Add(u);
            u.Visibility = Visibility.Visible;
        }
    }
}
