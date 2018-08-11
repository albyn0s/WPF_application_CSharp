using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_application
{
    /// <summary>
    /// Отдел
    /// </summary>
    class Department
    {
        /// <summary>
        /// Название отдела
        /// </summary>
        public string Name { get; set; }

        public Department() { }

        /// <summary>
        /// Создание отдела
        /// </summary>
        /// <param name="_departName">Отдел</param>
        public Department(string _departName)
        {
            Name = _departName;
        }

        /// <summary>
        /// Переопределение ToString();
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
