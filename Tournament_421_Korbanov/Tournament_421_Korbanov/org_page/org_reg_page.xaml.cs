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
using Tournament_421_Korbanov.db;
using Tournament_421_Korbanov.player_pages;

namespace Tournament_421_Korbanov.org_page
{
    /// <summary>
    /// Логика взаимодействия для org_reg_page.xaml
    /// </summary>
    public partial class org_reg_page : Page
    {
        public org_reg_page()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Player_auth_page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Text) || string.IsNullOrEmpty(PassTb.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            else
            {
                Organizer newOrg = new Organizer
                {
                    Name = nameTb.Text,
                    
                    Login = LoginTb.Text,
                    
                    Password = PassTb.Text,
                };
                App.db.Organizer.Add(newOrg);
                App.db.SaveChanges();
                MessageBox.Show("Успешно!");
                NavigationService.Navigate(new org_nav_page());
            }
        }
    }
}
