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
using Tournament_420_Sochnev_Renat_Agzyamovich.MyClasses;
using Tournament_420_Sochnev_Renat_Agzyamovich.MyPages.OrganizerPages;
using Tournament_420_Sochnev_Renat_Agzyamovich.MyPages.PlayerPages;

namespace Tournament_420_Sochnev_Renat_Agzyamovich.MyPages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text.Trim();
            string password = PasswordPb.Password.Trim();
            if (App.db.Organizer.FirstOrDefault(x => x.Login == login && x.Password == password) != null)
            {
                NavigationService.Navigate(new OrganizerTournamentListPage());
                return;
            }
            App.CurrentPlayer = App.db.Player.FirstOrDefault(x => x.Nickname == login && x.Password == password);
            if (App.CurrentPlayer != null)
            {
                NavigationService.Navigate(new PlayerTournamentListPage());
                return;
            }
            MessageClass.ErrorMessage("Неправильный логин или пароль");
        }
    }
}
