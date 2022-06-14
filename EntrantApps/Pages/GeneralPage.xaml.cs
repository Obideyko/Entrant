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

namespace EntrantApps.Pages
{
    /// <summary>
    /// Логика взаимодействия для GeneralPage.xaml
    /// </summary>
    public partial class GeneralPage : Page
    {
        public GeneralPage()
        {
            InitializeComponent();
            MainFrame1.Navigate(new EntrantPage());
            Manager1.MainFrame1 = MainFrame1;
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Внимание!",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Manager.MainFrame.Navigate(new EnterPage());
            }
        }

        private void EnBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame1.Navigate(new EntrantPage());
            Manager1.MainFrame1 = MainFrame1;
        }

        private void CeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame1.Navigate(new CertificatePage());
            Manager1.MainFrame1 = MainFrame1;
        }
    }
}
