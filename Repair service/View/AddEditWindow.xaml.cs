using Repair_service.DBStorrage;
using Repair_service.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
using System.Windows.Shapes;

namespace Repair_service.View
{
    /// <summary>
    /// Логика взаимодействия для AddEditWindow.xaml
    /// </summary>
    public partial class AddEditWindow : Window
    {
        private DBStorrage.Task _task;
        public AddEditWindow(DBStorrage.Task task)
        {
            InitializeComponent();
            _task = task;
            DataContext = _task;
            MessageBox.Show(_task.Client_phone_number, "", MessageBoxButton.OK, MessageBoxImage.Error);
            

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new RepairServiceEntities())
                {
                    _task.ID = 3;
                    db.Task.AddOrUpdate(_task);
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
              

                MessageBox.Show($"Произошла ошибка\nПодробности:\n{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
