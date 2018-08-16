using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_application
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public class Employee : INotifyPropertyChanged //интерфейс для проверки изменения
    {
        static Random r = new Random();

        private string _name; //Имя
        private string _surname; //Фамилия
        private int _age; //Возраст
        private string _department; //Отдел

        /// <summary>
        /// Имя
        /// </summary>
        /// 
        public string Name
        {
            get { return _name; }
            set { _name = value;
                OnPropertyChanged("Name");//проверка на изменения
            }
        }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string SurName
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged("SurName");//проверка на изменения
            }
        }
        /// <summary>
        /// Возвраст
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("Age");//проверка на изменения
            }
        }

        /// <summary>
        /// Отдел
        /// </summary>
        public string Department_
        {
            get { return _department; }
            set
            {
                _department = value;
                OnPropertyChanged("Department_");//проверка на изменения
            }
        }

        /// <summary>
        /// Свойство на "Изменение"
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Заполняем случайными значениями
        /// </summary>
        /// <returns></returns>
        public static Employee[] GetEmployees()
        {
            var result = new Employee[]
            {
                new Employee() { Name = $"User_name_0", SurName = $"SurName_0", Age = r.Next(20, 30) },
                new Employee() { Name = $"User_name_1", SurName = $"SurName_1", Age = r.Next(20, 30) },
                new Employee() { Name = $"User_name_2", SurName = $"SurName_2", Age = r.Next(20, 30) },
                new Employee() { Name = $"User_name_3", SurName = $"SurName_3", Age = r.Next(20, 30) }
            };
            return result;
        }

        /// <summary>
        /// Проверка на изменение свойства
        /// </summary>
        /// <param name="propertyName"></param>
        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
       
    }
}
