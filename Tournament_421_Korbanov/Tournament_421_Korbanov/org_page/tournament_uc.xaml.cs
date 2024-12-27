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
    /// Логика взаимодействия для tournament_uc.xaml
    /// </summary>
    public partial class tournament_uc : UserControl
    {
        
        public tournament_uc(Tournament tournament)
        {
            InitializeComponent();
            DateTime startDate = Convert.ToDateTime(tournament.Start_date);
            DateTime endDate = Convert.ToDateTime(tournament.End_date);
            Start_date_tb.Text = startDate.ToString("dd.MM.yyyy");
            End_date_tb.Text = endDate.ToString("dd.MM.yyyy");
            title_tb.Text = tournament.Name;
            fond_tb.Text = $"{tournament.Prize_fund.ToString()}₽";

            var game = App.db.Game.FirstOrDefault(x => x.id == tournament.Game_id) ;
            game_tb.Text = game.Name;

            var categoreGame = App.db.Tournament_type.FirstOrDefault(x => x.id == tournament.Type_id);
            game_category_tb.Text = categoreGame.Name;
        }

    }
}
