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
using Tournament_420_Sochnev_Renat_Agzyamovich.MyPages.OrganizerPages;

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
            if(login == "0000" && password == "0000")
            {
                NavigationService.Navigate(new OrganizerTournamentListPage());
                return;
            }
            MessageBox.Show();
        }
    }
}
