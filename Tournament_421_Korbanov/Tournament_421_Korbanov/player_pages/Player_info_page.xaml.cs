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

namespace Tournament_421_Korbanov.player_pages
{
    /// <summary>
    /// Логика взаимодействия для Player_info_page.xaml
    /// </summary>
    public partial class Player_info_page : Page
    {
        Player thisPlayer = App.totalPlayer;
        public Player_info_page()
        {
            InitializeComponent();
            id_tb.Text = thisPlayer.id.ToString();
            nickname_tb.Text = thisPlayer.Nickname;
            phone_number_tb.Text = thisPlayer.Phone_number;
            name_tb.Text = thisPlayer.Name;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Player_nav_page());
        }
        

    }
}
