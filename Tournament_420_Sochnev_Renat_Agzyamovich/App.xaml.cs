using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tournament_420_Sochnev_Renat_Agzyamovich.DB;

namespace Tournament_420_Sochnev_Renat_Agzyamovich
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TournamentDB_420_Sochnev_Renat_AgzyamovichEntities db = new TournamentDB_420_Sochnev_Renat_AgzyamovichEntities();

        public static Player CurrentPlayer { get; set; }
    }
}
