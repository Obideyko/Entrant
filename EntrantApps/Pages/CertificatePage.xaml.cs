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
    /// Логика взаимодействия для CertificatePage.xaml
    /// </summary>
    public partial class CertificatePage : Page
    {
        public CertificatePage()
        {
            InitializeComponent();
            DGridCertificate.ItemsSource = EntrantBaseEntities.GetContext().Certificate.ToList();

            if(EnterPage.Global.actor == "Технический секретарь")
            {
                AddBtn.Margin = new Thickness(0);
                AddBtn.HorizontalAlignment = HorizontalAlignment.Center;
                DelBtn.Visibility = Visibility.Hidden;
                ExBtn.Visibility = Visibility.Hidden;
                CalculateColumns.Visibility = Visibility.Hidden;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame1.Navigate(new CertificateAddEditPage(null));
        }

        private void UpdateEntrant()
        {
            var currentCertificate = EntrantBaseEntities.GetContext().Certificate.ToList();

            currentCertificate = currentCertificate.Where(p => p.Number.ToLower().Contains(tBox.Text.ToLower())).ToList();

            DGridCertificate.ItemsSource = currentCertificate.OrderBy(p => p.Number).ToList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateEntrant();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateEntrant();
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            var certificateForRemoving = DGridCertificate.SelectedItems.Cast<Certificate>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {certificateForRemoving.Count()} элементов?", "Внимаение!",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    EntrantBaseEntities.GetContext().Certificate.RemoveRange(certificateForRemoving);
                    EntrantBaseEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGridCertificate.ItemsSource = EntrantBaseEntities.GetContext().Certificate.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame1.Navigate(new CertificateAddEditPage((sender as Button).DataContext as Certificate));
        }
        private void ExBtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            for (int j = 0; j < DGridCertificate.Columns.Count; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, j + 1];
                sheet1.Cells[1, j + 1].Font.Bold = true;
                sheet1.Columns[j + 1].ColumnWidth = 15;
                myRange.Value2 = DGridCertificate.Columns[j].Header;
            }
            for (int i = 0; i < DGridCertificate.Columns.Count; i++)
            {
                for (int j = 0; j < DGridCertificate.Items.Count; j++)
                {
                    TextBlock b = DGridCertificate.Columns[i].GetCellContent(DGridCertificate.Items[j]) as TextBlock;
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                    if (b != null)
                    {
                        myRange.Value2 = b.Text;
                    }
                    else
                    {
                        myRange.Value2 = "";
                    }
                }
                sheet1.Columns.EntireColumn.AutoFit();
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                EntrantBaseEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridCertificate.ItemsSource = EntrantBaseEntities.GetContext().Certificate.ToList();
            }
        }
    }
}
