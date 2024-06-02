using Repair_service.ViewModel;
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
using System.Windows.Shapes;

namespace Repair_service.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowVM();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowVM).DeleteTask();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            new AddEditWindow((DataContext as MainWindowVM).SelectedTask);
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow res = new AddEditWindow((DataContext as MainWindowVM).SelectedTask);
            res.ShowDialog();
        }
    }
}
