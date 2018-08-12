using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_application
{
    /// <summary>
    /// Отдел
    /// </summary>
    public class Department : INotifyPropertyChanged//интерфейс для проверки изменения
    {
        private string _DepName; //Название отдела

        /// <summary>
        /// Свойство на "Изменение"
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Название отдела
        /// </summary>
        /// 
        public string DepName
        {
            get { return _DepName; }
            set
            {
                _DepName = value;
                OnPropertyChanged("DepName");//проверка на изменения
            }
        }
        
        /// <summary>
        /// Заполняем случайными значениями
        /// </summary>
        /// <returns></returns>
        public static Department[] GetDepartments()
        {
            var result = new Department[]
            {
                new Department() { DepName = $"Dep_name_0" },
                new Department() { DepName = $"Dep_name_1" },
                new Department() { DepName = $"Dep_name_2" },
                new Department() { DepName = $"Dep_name_3" },

            };
            return result;
        }

        public override string ToString()
        {
            return $"{DepName}";
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
