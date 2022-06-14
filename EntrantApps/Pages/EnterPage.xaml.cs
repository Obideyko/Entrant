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
    /// Логика взаимодействия для EnterPage.xaml
    /// </summary>
    public partial class EnterPage : Page
    {
        public static class Global
        {
            public static string actor;
        }

        public EnterPage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginBox.Text) || string.IsNullOrEmpty(Password.Password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            using (var db = new EntrantBaseEntities())
            {
                var user = db.Users
                    .AsNoTracking()
                    .FirstOrDefault(u => u.Login == LoginBox.Text && u.Password == Password.Password);

                if (user == null)
                {
                    MessageBox.Show("Пользователь не найден!");
                    return;
                }
                
                if(user.Role == "Ответственный секретарь")
                {
                    Global.actor = "Ответственный секретарь";
                    Manager.MainFrame.Navigate(new GeneralPage());
                }
                if (user.Role == "Технический секретарь")
                {
                    Global.actor = "Технический секретарь";
                    Manager.MainFrame.Navigate(new GeneralPage());
                }
            }
        }
    }
}
