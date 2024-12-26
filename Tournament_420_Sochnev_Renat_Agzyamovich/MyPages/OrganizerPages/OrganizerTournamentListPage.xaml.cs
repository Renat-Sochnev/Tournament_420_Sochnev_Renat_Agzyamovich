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

namespace Tournament_420_Sochnev_Renat_Agzyamovich.MyPages.OrganizerPages
{
    /// <summary>
    /// Логика взаимодействия для OrganizerTournamentListPage.xaml
    /// </summary>
    public partial class OrganizerTournamentListPage : Page
    {
        public OrganizerTournamentListPage()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }
    }
}
