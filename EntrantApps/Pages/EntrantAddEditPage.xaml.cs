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
    /// Логика взаимодействия для EntrantAddEditPage.xaml
    /// </summary>
    public partial class EntrantAddEditPage : Page
    {
        private Entrant _currentEntrant = new Entrant();

        public EntrantAddEditPage(Entrant selectedEntrant)
        {
            InitializeComponent();

            if (selectedEntrant != null)
                _currentEntrant = selectedEntrant;

            DataContext = _currentEntrant;
            ComboCertificate.ItemsSource = EntrantBaseEntities.GetContext().Certificate.ToList();
            ComboSpecialization.ItemsSource = EntrantBaseEntities.GetContext().Specialization.ToList();

            if (selectedEntrant == null)
            {
                _currentEntrant.Birthday = DateTime.Now;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentEntrant.Name))
                errors.AppendLine("Введите ФИО");
            if (_currentEntrant.Birthday == null)
                errors.AppendLine("Введите Дату рождения");
            if (string.IsNullOrWhiteSpace(_currentEntrant.Place_of_birth))
                errors.AppendLine("Введите Место рождения");
            if (string.IsNullOrWhiteSpace(_currentEntrant.Passport))
                errors.AppendLine("Введите Серию и номер паспорта");
            if (string.IsNullOrWhiteSpace(_currentEntrant.Whem_and_by_whom_issued))
                errors.AppendLine("Введите Когда и кем выдан");
            if (string.IsNullOrWhiteSpace(_currentEntrant.Place_of_residence))
                errors.AppendLine("Введите Место проживания");
            if (string.IsNullOrWhiteSpace(_currentEntrant.SNILS))
                errors.AppendLine("Введите Номер СНИЛСа");
            if (string.IsNullOrWhiteSpace(_currentEntrant.Medical_policy))
                errors.AppendLine("Введите Номер медицинского полиса");
            if (string.IsNullOrWhiteSpace(_currentEntrant.Telephone))
                errors.AppendLine("Введите Номер телефона");
            if (_currentEntrant.Specialization == null)
                errors.AppendLine("Выберите Специальность");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentEntrant.ID == 0)
                EntrantBaseEntities.GetContext().Entrant.Add(_currentEntrant);

            try
            {
                EntrantBaseEntities.GetContext().SaveChanges();
                MessageBox.Show("Успешно!");
                Manager1.MainFrame1.Navigate(new EntrantPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
