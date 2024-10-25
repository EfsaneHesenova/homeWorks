using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflectiontask.Models
{
    internal class User
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string SurName { get; set; }
        private static int Age;
        void GetFullName()
        {
            Console.WriteLine(Name + " "  + SurName);
        }
        static void ChangeAge(int age)
        {
            Age = age;  
        }
    }
}
