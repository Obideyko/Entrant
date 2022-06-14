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
    /// Логика взаимодействия для EntrantPage.xaml
    /// </summary>
    public partial class EntrantPage : Page
    {
        public EntrantPage()
        {
            InitializeComponent();
            var allSpecialization = EntrantBaseEntities.GetContext().Specialization.ToList();
            allSpecialization.Insert(0, new Specialization
            {
                Name = "Все специальности"
            });

            ComboSpec.ItemsSource = allSpecialization;
            ComboSpec.SelectedIndex = 0;

            if(EnterPage.Global.actor == "Технический секретарь")
            {
                AddBtn.Margin = new Thickness(0);
                AddBtn.HorizontalAlignment = HorizontalAlignment.Center;
                DelBtn.Visibility = Visibility.Hidden;
                ExBtn.Visibility = Visibility.Hidden;
            }

            UpdateEntrant();
        }

        private void UpdateEntrant()
        {
            var currentEntrant = EntrantBaseEntities.GetContext().Entrant.ToList();

            if (ComboSpec.SelectedIndex > 0)
            {
                currentEntrant = currentEntrant.Where(p => p.Specialization.ID == ComboSpec.SelectedIndex).ToList();
            }

            currentEntrant = currentEntrant.Where(p => p.Name.ToLower().Contains(tBox.Text.ToLower()) || 
            p.Place_of_residence.ToLower().Contains(tBox.Text.ToLower())).ToList();

            DGridEntrant.ItemsSource = currentEntrant.OrderBy(p => p.Name).ToList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateEntrant();
        }
        private void ComboSpec_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateEntrant();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame1.Navigate(new EntrantAddEditPage(null));
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            var entrantForRemoving = DGridEntrant.SelectedItems.Cast<Entrant>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {entrantForRemoving.Count()} элементов?", "Внимаение!",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    EntrantBaseEntities.GetContext().Entrant.RemoveRange(entrantForRemoving);
                    EntrantBaseEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGridEntrant.ItemsSource = EntrantBaseEntities.GetContext().Entrant.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void ExBtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            for (int j = 0; j < DGridEntrant.Columns.Count; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, j + 1];
                sheet1.Cells[1, j + 1].Font.Bold = true;
                sheet1.Columns[j + 1].ColumnWidth = 15;
                myRange.Value2 = DGridEntrant.Columns[j].Header;
            }
            for (int i = 0; i < DGridEntrant.Columns.Count; i++)
            {
                for (int j = 0; j < DGridEntrant.Items.Count; j++)
                {
                    TextBlock b = DGridEntrant.Columns[i].GetCellContent(DGridEntrant.Items[j]) as TextBlock;
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
                DGridEntrant.ItemsSource = EntrantBaseEntities.GetContext().Entrant.ToList();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame1.Navigate(new EntrantAddEditPage((sender as Button).DataContext as Entrant));
        }
    }
}
