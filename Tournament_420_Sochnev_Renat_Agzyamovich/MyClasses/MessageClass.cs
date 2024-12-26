using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Tournament_420_Sochnev_Renat_Agzyamovich.MyClasses
{
    public class MessageClass
    {
        public static void InfoMessage(string text)
        {
            MessageBox.Show(text, "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public static void WarningMessage(string text)
        {
            MessageBox.Show(text, "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        public static void ErrorMessage(string text)
        {
            MessageBox.Show(text, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
