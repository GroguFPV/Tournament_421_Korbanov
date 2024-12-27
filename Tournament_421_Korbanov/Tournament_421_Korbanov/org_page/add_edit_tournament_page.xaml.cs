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
    /// Логика взаимодействия для add_edit_tournament_page.xaml
    /// </summary>
    public partial class add_edit_tournament_page : Page
    {
        public add_edit_tournament_page()
        {

            InitializeComponent();
            if(App.totalOrganizer == null)
            {
                add_or_edit.Visibility = Visibility.Hidden;
            }

            StatusTb.IsReadOnly= true;
            StatusTb.Text = "Планируется";
            var Category = App.db.Tournament_type.ToList();
            Category_cb.ItemsSource = Category;
            Category_cb.DisplayMemberPath = "Name";

            var Games = App.db.Game.ToList();
            Game_Cb.ItemsSource = Games;
            Game_Cb.DisplayMemberPath = "Name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Name_tb.Text) || Start_date.SelectedDate == null ||
                string.IsNullOrEmpty(fond_tb.Text) || End_date.SelectedDate == null ||
                Game_Cb.SelectedItem == null || Category_cb.SelectedItem == null || Game_Cb.SelectedItem == null)
            {
                MessageBox.Show("Заполните все поля");
                return; 
            }
            else
            {
                var categoreGame = Category_cb.SelectedItem as Tournament_type;


                var gameID = Game_Cb.SelectedValue as Game;

              

                Tournament new_tournament = new Tournament
                {
                    Name = Name_tb.Text,
                    End_date = Start_date.SelectedDate,
                    Start_date = Start_date.SelectedDate,
                    Prize_fund = Convert.ToInt32(fond_tb.Text),
                    Status_id = 1,
                    Type_id = categoreGame.id,
                    Game_id = gameID.id,

                };
                App.db.Tournament.Add(new_tournament);
                App.db.SaveChanges();
                MessageBox.Show("Успешно добавлено!");
                NavigationService.Navigate(new Tournament_list_page());
            }
            
        }
    }
}
