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
    /// Логика взаимодействия для PlayerTournamentListPage.xaml
    /// </summary>
    public partial class PlayerTournamentListPage : Page
    {
        public PlayerTournamentListPage()
        {
            InitializeComponent();
            TournamentLv.ItemsSource = App.db.Tournament.Where(x => x.Date >= DateTime.Today).OrderBy(x => x.Date).ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }

        private void GoToTournamentBtn_Click(object sender, RoutedEventArgs e)
        {
            Tournament tournament = (sender as Button).DataContext as Tournament;
            NavigationService.Navigate(new PlayerTournamentInfoPage(tournament));
        }
    }
}
