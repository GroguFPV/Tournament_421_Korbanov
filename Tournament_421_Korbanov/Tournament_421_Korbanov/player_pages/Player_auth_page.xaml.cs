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

namespace Tournament_421_Korbanov.player_pages
{
    /// <summary>
    /// Логика взаимодействия для Player_auth_page.xaml
    /// </summary>
    public partial class Player_auth_page : Page
    {
        public Player_auth_page()
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
            var user = App.db.Player.FirstOrDefault(x => x.Login == LoginTb.Text || x.Password == PassTb.Password);

            if (user != null)
            {
                MessageBox.Show("Добро пожаловать, " + user.Nickname);
                App.totalPlayer = user;
                App.totalOrganizer = null;
                NavigationService.Navigate(new Player_nav_page());

            }
            else MessageBox.Show("Пользователь не найден, проверь данные");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Player_reg_page());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Navigation_page());
        }
    }
}
