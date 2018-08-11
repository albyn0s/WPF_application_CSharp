using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_application
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    class Employee
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string SurName { get;  }
        /// <summary>
        /// Возвраст
        /// </summary>
        public string Age { get; }

        /// <summary>
        /// Пустой констуртор
        /// </summary>
        public Employee() { }
        
        
        public Employee(string name, string surname, string age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} {SurName} {Age}";
        }
    }
}
