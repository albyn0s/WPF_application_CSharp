using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_application
{
    class Program
    {
        Random r = new Random();
        Employee emp;
        Departament dep;

        public  List<Departament> dep_s = new List<Departament>();
        public  List<Employee> emp_s = new List<Employee>();

        public void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                dep_s.Add(dep = new Departament($"Depart_name_{r.Next(0,4)}"));
                emp_s.Add(emp = new Employee($"User_{i} ", $"Surname_{i} ", $"Age = {r.Next(20, 30)}"));
            }
        }
    }
}
