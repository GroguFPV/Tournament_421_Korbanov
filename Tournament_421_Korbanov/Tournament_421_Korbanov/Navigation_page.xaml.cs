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
using Tournament_421_Korbanov.org_page;
using Tournament_421_Korbanov.player_pages;

namespace Tournament_421_Korbanov
{
    /// <summary>
    /// Логика взаимодействия для Navigation_page.xaml
    /// </summary>
    public partial class Navigation_page : Page
    {
        public Navigation_page()
        {
            InitializeComponent();
        }

        private void player_zone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Player_auth_page());
        }

        private void admin_zone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new org_auth_page());
        }
    }
}
