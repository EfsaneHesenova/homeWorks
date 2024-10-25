using Reflectiontask.Models;
using System.Reflection;

namespace Reflectiontask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type userType = typeof(User);
            object userInstance = Activator.CreateInstance(userType);
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] Mytypes = assembly.GetTypes();

            PropertyInfo? privateIdProperty = userType.GetProperty("Id", BindingFlags.NonPublic | BindingFlags.Instance);
            privateIdProperty.SetValue(userInstance, 1);
            PropertyInfo? privateNameProperty = userType.GetProperty("Name", BindingFlags.NonPublic | BindingFlags.Instance);
            privateNameProperty.SetValue(userInstance, "Efsane");
            PropertyInfo? privateSurnameProperty = userType.GetProperty("SurName", BindingFlags.NonPublic | BindingFlags.Instance);
            privateSurnameProperty.SetValue(userInstance, "Hesenova");

            foreach (PropertyInfo item in userType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine($"{item.Name}: {item.GetValue(userInstance)}");
            }
            FieldInfo? privateAgeField = userType.GetField("Age", BindingFlags.NonPublic | BindingFlags.Static);
            privateAgeField.SetValue(userType, 20);
            Console.WriteLine($"{privateAgeField.Name}: {privateAgeField.GetValue(userType)}");

            MethodInfo GetFullNameMethod = userType.GetMethod("GetFullName", BindingFlags.NonPublic | BindingFlags.Instance);
            GetFullNameMethod.Invoke(userInstance, null);

            MethodInfo ChangeAgeMethod = userType.GetMethod("ChangeAge", BindingFlags.NonPublic | BindingFlags.Static);
            ChangeAgeMethod.Invoke(null, new object[] { 21 });
            Console.WriteLine($"new {privateAgeField.Name}: {privateAgeField.GetValue(userType)}");
        }
    }
}

