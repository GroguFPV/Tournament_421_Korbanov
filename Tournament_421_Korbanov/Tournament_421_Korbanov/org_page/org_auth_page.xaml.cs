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
using Tournament_421_Korbanov.player_pages;

namespace Tournament_421_Korbanov.org_page
{
    /// <summary>
    /// Логика взаимодействия для org_auth_page.xaml
    /// </summary>
    public partial class org_auth_page : Page
    {
        public org_auth_page()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Text) || string.IsNullOrEmpty(PassTb.Password))
            {
                MessageBox.Show("Заполните все данные");
                return;
            }
            var user = App.db.Organizer.FirstOrDefault(x => x.Login == LoginTb.Text || x.Password == PassTb.Password);

            if (user != null)
            {
                
                App.totalPlayer = null;
                App.totalOrganizer = user;
                NavigationService.Navigate(new org_nav_page());

            }
            else MessageBox.Show("Пользователь не найден, проверь данные");
        }

       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Navigation_page());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new org_reg_page());
        }
    }
}
