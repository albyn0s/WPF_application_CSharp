using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace WPF_application.ViewModel
{
    /// <summary>
    /// Основная модель (ViewModel)
    /// </summary>
    class MainWindowViewModel : INotifyPropertyChanged //интерфейс для проверки изменения
    {
        /// <summary>
        /// Выбранный сотрудник
        /// </summary>
        Employee selectedEmployee;
        /// <summary>
        /// Выбранный отдел
        /// </summary>
        Department selectedDepartment;

        private string _newDepText; // название для нового отдела

        public ObservableCollection<Employee> employees { get; private set; } //Сотрудники
        public ObservableCollection<Department> departaments { get; private set; } //Отделы

        /// <summary>
        /// Создание названия для нового отдела
        /// </summary>
        public string newDepText
        {
            get { return _newDepText; }
            set { _newDepText = value;
                OnPropertyChanged("newDepText"); //проверка на изменения
            }
        }
        /// <summary>
        /// Выбранный сотрудник
        /// </summary>
        public Employee SelectedEmployee
        {
            get { return selectedEmployee; }
            set { selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");//проверка на изменения
            }
        }
        
        /// <summary>
        /// Выбранный отдел
        /// </summary>
        public Department SelectedDepartment
        {
            get { return selectedDepartment; }
            set { selectedDepartment = value;
                OnPropertyChanged("SelectedDepartment");//проверка на изменения
            }
        }
        /// <summary>
        /// Добавить сотрудника
        /// </summary>
        public ICommand AddCommand { get; private set; }
        /// <summary>
        /// Удалить сотрудника
        /// </summary>
        public ICommand DelCommand { get; private set; }

        /// <summary>
        /// Добавить отдел
        /// </summary>
        public ICommand AddCommandD { get; private set; }
        /// <summary>
        /// Удалить отдел
        /// </summary>
        public ICommand DelCommandD { get; private set; }

        /// <summary>
        /// Сохранить
        /// </summary>
        public ICommand DepToEmployee { get; private set; }

        /// <summary>
        /// Создание коллекций и команд.
        /// </summary>
        public MainWindowViewModel()
        {
            employees = new ObservableCollection<Employee>(Employee.GetEmployees()); //Создаем коллекцию сотрудников.
            departaments = new ObservableCollection<Department>(Department.GetDepartments());//Создаем коллекцию отделов.

            AddCommandD = new DelegateCommand(Adddep); //Добавить отдел
            DelCommandD = new DelegateCommand(Deldep, CanRemoveDep); //удалить отдел

            DepToEmployee = new DelegateCommand(SaveDep); //Сохранить

            AddCommand = new DelegateCommand(AddEmployee); //Добавить сотрудника
            DelCommand = new DelegateCommand(DelEmployee, CanRemoveEmployee); //Удалить сотрудника

        }

        /// <summary>
        /// Сохранить
        /// </summary>
        /// <param name="obj"></param>
        private void SaveDep(object obj) //перенос поля из Department в Employee (пока что одно поле)
        {
            SelectedEmployee.Department_ = SelectedDepartment.DepName;
        }

        /// <summary>
        /// Проверка на удаление
        /// </summary>
        /// <param name="arg">передаваемый объект</param>
        /// <returns></returns>
        private bool CanRemoveDep(object arg)
        {
            return (arg as Department) != null;
        }

        /// <summary>
        /// Удалить отдел
        /// </summary>
        /// <param name="obj">Переданный отдел</param>
        private void Deldep(object obj)
        {
            departaments.Remove((Department)obj);
        }

        /// <summary>
        /// Добавить отдел
        /// </summary>
        /// <param name="obj"></param>
        private void Adddep(object obj)
        {
            departaments.Add(new Department { DepName = newDepText }); //добавляем новый отдел с название newDepText
        }

        /// <summary>
        /// Проверка на удаление сотрудника
        /// </summary>
        /// <param name="arg">Переданный сотрудник</param>
        /// <returns></returns>
        private bool CanRemoveEmployee(object arg)
        {
            return (arg as Employee) != null;
        }
        
        /// <summary>
        /// Удалить сотрудника
        /// </summary>
        /// <param name="obj">Переданный сотрудник</param>
        private void DelEmployee(object obj)
        {
            employees.Remove((Employee)obj);
        }

        /// <summary>
        /// Добавить сотрудника
        /// </summary>
        /// <param name="obj">Переданный сотрудник</param>
        void AddEmployee(object obj)
        {
            employees.Add(new Employee { Name = "Новый сотрудник", SurName = " ", Age = 0 });
        }

        /// <summary>
        /// Событие на изменение
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Проверка на изменение
        /// </summary>
        /// <param name="propertyName">Переданная переменная/объект</param>
        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
