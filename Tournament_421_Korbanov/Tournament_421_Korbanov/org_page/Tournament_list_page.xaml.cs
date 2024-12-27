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

namespace Tournament_421_Korbanov.org_page
{
    /// <summary>
    /// Логика взаимодействия для Tournament_list_page.xaml
    /// </summary>
    public partial class Tournament_list_page : Page
    {
        public Tournament_list_page()
        {
            InitializeComponent();
            Refresh();
            status_cb.SelectedIndex= 3;
        }
        public void Refresh()
        {
            var list = App.db.Tournament.ToList();

            if (!string.IsNullOrEmpty(SearchTb.Text))
            {
                list = list.Where(x => x.Name.ToLower().Contains(SearchTb.Text.ToLower())).ToList();
            }

            
            if (status_cb.SelectedItem != null)
            {
                if (status_cb.SelectedIndex == 0)
                {
                    list = list.Where(x => x.Status_id == 2).ToList();
                }
                else if (status_cb.SelectedIndex == 1)
                {

                    list = list.Where(x => x.Status_id == 1).ToList();
                }
                else if (status_cb.SelectedIndex == 3)
                {

                    list = list.ToList();
                }
            }

            Tournament_list_WP.Children.Clear();
            foreach (Tournament tournament in list)
            {
                Tournament_list_WP.Children.Add(new tournament_uc(tournament));
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void status_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void AddTournament_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new add_edit_tournament_page());
        }
    }
}
