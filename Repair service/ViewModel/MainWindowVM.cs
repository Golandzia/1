using Repair_service.DBStorrage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Repair_service.ViewModel
{
    public class MainWindowVM : BaseVM
    {
        private ObservableCollection<DBStorrage.Task> _task;
        private int _id;
        private DateTime _dateOfAdding;
        private DateTime _dateOfTaskClosing;
        private string _equipmentForRepair;
        private string _typeOfIssue;
        private string _descriptionOfIssue;
        private string _surnameOfCustomer;
        private string _nameOfCustomer;
        private string _phoneNumber;
        private Task_status _taskStatus;
        private Employee _employee;
        private DBStorrage.Task _selectedTask;

        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(ID));
            }
        }
        public ObservableCollection<DBStorrage.Task> Task
        {
            get { return _task; }
            set
            {
                _task = value;
                OnPropertyChanged(nameof(Task));
            }
        }
        public DateTime DateOfAdding
        {
            get { return _dateOfAdding; }
            set
            {
                _dateOfAdding = value;
                OnPropertyChanged(nameof(DateOfAdding));
            }
        }
        public DateTime DateTimeOfTaskClosing
        {
            get { return _dateOfTaskClosing; }
            set
            {
                _dateOfTaskClosing = value;
                OnPropertyChanged(nameof(DateTimeOfTaskClosing));
            }
        }
        public string EquipmentForRepair
        {
            get { return _equipmentForRepair; }
            set
            {
                _equipmentForRepair = value;
                OnPropertyChanged(nameof(EquipmentForRepair));
            }
        }
        public string TypeOfIssue
        {
            get { return _typeOfIssue; }
            set
            {
                _typeOfIssue = value;
                OnPropertyChanged(nameof(TypeOfIssue));
            }
        }
        public string DescriptionOfIssue
        {
            get { return _descriptionOfIssue; }
            set
            {
                _descriptionOfIssue = value;
                OnPropertyChanged(nameof(DescriptionOfIssue));
            }
        }
        public string SurnameOfCustomer
        {
            get { return _surnameOfCustomer; }
            set
            {
                _surnameOfCustomer = value;
                OnPropertyChanged(nameof(SurnameOfCustomer));
            }
        }
        public string NameOfCustomer
        {
            get { return _nameOfCustomer; }
            set
            {
                _nameOfCustomer = value;
                OnPropertyChanged(nameof(NameOfCustomer));
            }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }
        public Task_status TaskStatus
        {
            get { return _taskStatus; }
            set
            {
                _taskStatus = value;
                OnPropertyChanged(nameof(TaskStatus));
            }
        }
        public Employee Employee
        {
            get { return _employee; }
            set
            {
                _employee = value;
                OnPropertyChanged(nameof(Employee));
            }
        }
        public DBStorrage.Task SelectedTask
        {
            get { return _selectedTask; }
            set
            {
                _selectedTask = value;
                OnPropertyChanged(nameof(SelectedTask));
            }
        }


        public MainWindowVM()
        {
            Task = new ObservableCollection<DBStorrage.Task>();

            FillTasks();
        }
        private void FillTasks()
        {
            try
            {
                using (var db = new RepairServiceEntities())
                {
                    var res = db.Task.ToList();
                    res.ForEach(elem => Task?.Add(elem));
                }
            }
            catch (Exception) { MessageBox.Show(""); }
            
        }

        public void DeleteTask()
        {
            var res = MessageBox.Show("Выбранный элемент будет удалён, продолжить?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (res == MessageBoxResult.Yes)
            {
                try
                {
                    using (var db = new RepairServiceEntities())
                    {
                        var entityForDelete = db.Task.Where(elem => elem.ID == SelectedTask.ID).FirstOrDefault();
                        db.Task.Remove(entityForDelete);
                        db.SaveChanges();
                        Task?.Clear();
                        FillTasks();
                    }
                }
                catch (Exception) { MessageBox.Show(""); }
            }
        }

    }
}
