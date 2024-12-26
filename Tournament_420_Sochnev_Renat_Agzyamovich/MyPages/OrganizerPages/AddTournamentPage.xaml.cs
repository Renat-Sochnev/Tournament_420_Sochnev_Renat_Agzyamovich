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
using Tournament_420_Sochnev_Renat_Agzyamovich.MyClasses;

namespace Tournament_420_Sochnev_Renat_Agzyamovich.MyPages.OrganizerPages
{
    /// <summary>
    /// Логика взаимодействия для AddTournamentPage.xaml
    /// </summary>
    public partial class AddTournamentPage : Page
    {
        public AddTournamentPage()
        {
            InitializeComponent();
            DateDp.DisplayDateStart = DateTime.Now;
            GameCb.ItemsSource = App.db.Game.ToList();
            GameCb.DisplayMemberPath = "Name";
            FormatCb.ItemsSource = App.db.Format.ToList();
            FormatCb.DisplayMemberPath = "Name";
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrganizerTournamentListPage());
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(NameTb.Text) || DateDp.SelectedDate == null 
                || GameCb.SelectedIndex == -1 || FormatCb.SelectedIndex == -1)
            {
                MessageClass.WarningMessage("Заполните все поля");
                return;
            }
            Tournament tournament = new Tournament()
            {
                Name = NameTb.Text,
                Date = DateDp.SelectedDate,
                IdGame = (GameCb.SelectedItem as Game).Id,
                IdFormat = (FormatCb.SelectedItem as Format).Id,
            };
            App.db.Tournament.Add(tournament);
            App.db.SaveChanges();
            MessageClass.InfoMessage("Турнир добавлен");
            NavigationService.Navigate(new OrganizerTournamentListPage());
        }
    }
}
