using Repair_service.DBStorrage;
using Repair_service.View;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Repair_service.ViewModel
{
    public class AuthorizationWindowVM : BaseVM
    {
        private string _login;
        private string _password;

        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }


        public void Authorization()
        {
            if(Login != null && Login != "" && Password != null && Password != "")
            {
                using (var db = new RepairServiceEntities())
                {
                    var res = db.Employee.FirstOrDefault(x => x.Login == Login && x.Password == Password);
                    if (res != null)
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        foreach (var item in App.Current.Windows) {
                            if (item is AuthorizationWindow) (item as Window).Close();
                        }
                    }
                    else MessageBox.Show("Введены неверный логин или пароль", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else MessageBox.Show("Вы не ввели логин или пароль", "", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
