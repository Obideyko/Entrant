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
    /// Логика взаимодействия для CertificateAddEditPage.xaml
    /// </summary>
    public partial class CertificateAddEditPage : Page
    {
        private Certificate _currentCertificate = new Certificate();

        public CertificateAddEditPage(Certificate selectedCertificate)
        {
            InitializeComponent();

            if (selectedCertificate != null)
                _currentCertificate = selectedCertificate;

            DataContext = _currentCertificate;
            ComboEntrant.ItemsSource = EntrantBaseEntities.GetContext().Entrant.ToList();

            if(EnterPage.Global.actor == "Технический секретарь")
            {
                GrAver.Visibility = Visibility.Hidden;
                TBAver.Visibility = Visibility.Hidden;
                BtnCalculate.Visibility = Visibility.Hidden;
                BtnSave.HorizontalAlignment = HorizontalAlignment.Center;
                BtnSave.Margin = new Thickness(0);
            }

        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            float a = Convert.ToInt32(_currentCertificate.Russian_language);
            float b = Convert.ToInt32(_currentCertificate.Literature);
            float c = Convert.ToInt32(_currentCertificate.Native_language);
            float d = Convert.ToInt32(_currentCertificate.Nativa_literature);
            float ee = Convert.ToInt32(_currentCertificate.Algebra);
            float f = Convert.ToInt32(_currentCertificate.Geometry);
            float g = Convert.ToInt32(_currentCertificate.History);
            float h = Convert.ToInt32(_currentCertificate.Social_studies);
            float i = Convert.ToInt32(_currentCertificate.Geography);
            float j = Convert.ToInt32(_currentCertificate.Physics);
            float k = Convert.ToInt32(_currentCertificate.Biology);
            float l = Convert.ToInt32(_currentCertificate.Chemistry);
            float m = Convert.ToInt32(_currentCertificate.Foreign_language);
            float n = Convert.ToInt32(_currentCertificate.OBZH);
            float o = Convert.ToInt32(_currentCertificate.Informatics);
            float p = Convert.ToInt32(_currentCertificate.Physica_culture);
            float q = Convert.ToInt32(_currentCertificate.Technology);
            float r = Convert.ToInt32(_currentCertificate.Art);
            float s = Convert.ToInt32(_currentCertificate.Music);
            float x = 19f;
            if (a == 0)
                x -= 1;
            if (b == 0)
                x -= 1;
            if (c == 0)
                x -= 1;
            if (d == 0)
                x -= 1;
            if (ee == 0)
                x -= 1;
            if (f == 0)
                x -= 1;
            if (g == 0)
                x -= 1;
            if (h == 0)
                x -= 1;
            if (i == 0)
                x -= 1;
            if (j == 0)
                x -= 1;
            if (k == 0)
                x -= 1;
            if (l == 0)
                x -= 1;
            if (m == 0)
                x -= 1;
            if (n == 0)
                x -= 1;
            if (o == 0)
                x -= 1;
            if (p == 0)
                x -= 1;
            if (q == 0)
                x -= 1;
            if (r == 0)
                x -= 1;
            if (s == 0)
                x -= 1;
            float avg1 = (a + b + c + d + ee + f + g + h + i + j + k + l + m + n + o + p + q + r + s) / x;
            var y = Math.Round(avg1, 2).ToString();
            TextAvg.Text = y.Replace(",", ".");
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (_currentCertificate.Entrant1 == null)
                errors.AppendLine("Выберите ФИО");
            if (string.IsNullOrWhiteSpace(_currentCertificate.Number))
                errors.AppendLine("Введите Номер аттестата");
            if (_currentCertificate.Russian_language < 0 || _currentCertificate.Russian_language > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Literature < 0 || _currentCertificate.Literature > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Native_language < 0 || _currentCertificate.Native_language > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Nativa_literature < 0 || _currentCertificate.Nativa_literature > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Algebra < 0 || _currentCertificate.Algebra > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Geometry < 0 || _currentCertificate.Geometry > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.History < 0 || _currentCertificate.History > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Social_studies < 0 || _currentCertificate.Social_studies > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Geography < 0 || _currentCertificate.Geography > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Physics < 0 || _currentCertificate.Physics > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Biology < 0 || _currentCertificate.Biology > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Chemistry < 0 || _currentCertificate.Chemistry > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Foreign_language < 0 || _currentCertificate.Foreign_language > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.OBZH < 0 || _currentCertificate.OBZH > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Informatics < 0 || _currentCertificate.Informatics > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Physica_culture < 0 || _currentCertificate.Physica_culture > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Technology < 0 || _currentCertificate.Technology > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Art < 0 || _currentCertificate.Art > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");
            if (_currentCertificate.Music < 0 || _currentCertificate.Music > 5)
                errors.AppendLine("Оценка меньше 0 или больше 5");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentCertificate.ID == 0)
                EntrantBaseEntities.GetContext().Certificate.Add(_currentCertificate);

            try
            {
                EntrantBaseEntities.GetContext().SaveChanges();
                MessageBox.Show("Успешно!");
                Manager1.MainFrame1.Navigate(new CertificatePage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
