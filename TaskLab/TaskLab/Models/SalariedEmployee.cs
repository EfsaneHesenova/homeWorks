using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLab.Models
{
    internal class SalariedEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public SalariedEmployee(string name, string surname, int age, double monthlySalary) : base(name, surname, age)
        {
            MonthlySalary = monthlySalary;
        }
        protected override double CalculateSalary()
        {
            return MonthlySalary;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"id {Id} \nname: {Name} \nsurname {SurName} \nage: {Age} \nsalary {CalculateSalary()}");
        }
    }
}
