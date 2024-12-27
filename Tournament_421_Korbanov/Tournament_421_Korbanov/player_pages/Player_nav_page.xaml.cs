using System;
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

namespace Tournament_421_Korbanov.player_pages
{
    /// <summary>
    /// Логика взаимодействия для Player_nav_page.xaml
    /// </summary>
    public partial class Player_nav_page : Page
    {
        public Player_nav_page()
        {
            InitializeComponent();
        }

        private void player_zone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Player_info_page());
        }

        private void admin_zone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Tournament_list_page());
        }
    }
}
