using Accessmodifierstask.Models;
using ValidatorLibrary;

namespace Accessmodifierstask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string userUserName = "Efsane2004";
            string userPassword = "ExamplePassword1!@";
            string userName = "Efsane";
            string userSurNAme = "Hesenova";
            byte userAge = 20;
            string userBirthday = "2004-04-15";

            Person person = new Person(userUserName, userPassword, userName, userSurNAme, userAge, userBirthday);
            person.GetInfo();
        }
    }
}
