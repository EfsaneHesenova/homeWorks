using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLab.Models
{
    internal class HourlyEmployee : Employee
    {


        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        public HourlyEmployee(string name, string surname, int age, double hourlyrate, double hoursworked) : base(name, surname, age)
        {
            HourlyRate = hourlyrate;
            HoursWorked = hoursworked;
        }

        protected override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }




        public override void DisplayDetails()
        {
            Console.WriteLine($"id {Id} \nname: {Name} \nsurname {SurName} \nage: {Age} \nsalary {CalculateSalary()}");
        }
    }
}
