using TaskLab.Models;

namespace TaskLab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string type;

            while (true)
            {
                Console.WriteLine("Monthly or Hourly");
                type = Console.ReadLine();
                Console.WriteLine("name:");
                string userName = Console.ReadLine();
                Console.WriteLine("surname");
                string userSurnamee = Console.ReadLine();
                Console.WriteLine("age:");
                int useAge = int.Parse(Console.ReadLine());
                
                if (type == "Monthly")
                {
                    Console.WriteLine("salary:");
                    double userMonthlySalary = double.Parse(Console.ReadLine());
                    SalariedEmployee salariedEmployee = new SalariedEmployee(userName, userSurnamee, useAge, userMonthlySalary);
                    salariedEmployee.DisplayDetails();
                }
                else if (type == "Hourly")
                {
                    Console.WriteLine("salary: ");
                    double userHourlySalary = double.Parse(Console.ReadLine());
                    Console.WriteLine("hours: ");
                    double userHours = double.Parse(Console.ReadLine());
                    HourlyEmployee hourlyEmployee = new HourlyEmployee(userName, userSurnamee, useAge, userHourlySalary, userHours);
                    hourlyEmployee.DisplayDetails();
                }


            }
        }
    }
}
