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
        public string Name { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string SurName { get; set; }
        /// <summary>
        /// Возвраст
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Пустой констуртор
        /// </summary>
        public Employee() { }
        
        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="age">Возраст</param>
        public Employee(string name, string surname, int age, int id)
        {
            Name = name;
            SurName = surname;
            Age = age;
            Id = id;
        }

        /// <summary>
        /// Переопределние ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Id} {Name} {SurName} {Age}";
        }
    }
}
