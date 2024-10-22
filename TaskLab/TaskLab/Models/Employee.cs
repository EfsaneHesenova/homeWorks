using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLab.Models
{
    internal abstract class Employee
    {
        private static int _id;
        public virtual int Id => _id;
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public Employee(string name, string surname, int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
            _id++;
        }

        protected abstract double CalculateSalary();
        public abstract void DisplayDetails();
    }
}
