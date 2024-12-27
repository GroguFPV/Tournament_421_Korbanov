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

namespace Tournament_421_Korbanov.org_page
{
    /// <summary>
    /// Логика взаимодействия для org_nav_page.xaml
    /// </summary>
    public partial class org_nav_page : Page
    {
        public org_nav_page()
        {
            InitializeComponent();
        }

        private void player_zone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Tournament_list_page());
        }
    }
}
