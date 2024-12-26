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
using Tournament_420_Sochnev_Renat_Agzyamovich.DB;

namespace Tournament_420_Sochnev_Renat_Agzyamovich.MyPages.PlayerPages
{
    /// <summary>
    /// Логика взаимодействия для PlayerTournamentInfoPage.xaml
    /// </summary>
    public partial class PlayerTournamentInfoPage : Page
    {
        public static Tournament ContextTournament {  get; set; }
        public PlayerTournamentInfoPage(Tournament tournament)
        {
            InitializeComponent();
            ContextTournament = tournament;
            NameTb.Text = ContextTournament.Name;
            DateTb.Text = string.Format("dd.MM.yyyy", ContextTournament.Date);
            GameTb.Text = ContextTournament.Game.Name;
            FormatTb.Text = ContextTournament.Format.Name;
            TournamentRegistration tournamentRegistration = App.db.TournamentRegistration.FirstOrDefault(x => x.IdTournament == ContextTournament.Id && x.IdMember == App.CurrentPlayer.Id);
            if (tournamentRegistration == null)
            {
                StatusPanel.Visibility = Visibility.Collapsed;
            }
            else
            {
                StatusTb.Text = tournamentRegistration.Status.Name;
                MakeApplicationBtn.Visibility = Visibility.Collapsed;
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PlayerTournamentListPage());
        }

        private void MakeApplicationBtn_Click(object sender, RoutedEventArgs e)
        {
            TournamentRegistration tournamentRegistration = new TournamentRegistration()
            {
                IdMember = App.CurrentPlayer.Id,
                IdStatus = 1,
                IdTournament = ContextTournament.Id,
            };
            App.db.TournamentRegistration.Add(tournamentRegistration);
            App.db.SaveChanges();
            MakeApplicationBtn.Visibility = Visibility.Collapsed;
            StatusPanel.Visibility = Visibility.Visible;
            StatusTb.Text = "На рассмотрении";
        }
    }
}
