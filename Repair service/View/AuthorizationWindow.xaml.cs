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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            this.DataContext = new AuthorizationWindowVM();
            InitializeComponent();
        }


        private void AuthorizateBtn_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as AuthorizationWindowVM).Authorization();
        }
    }
}
