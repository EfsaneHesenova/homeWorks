using Indexertask.Models;

namespace Indexertask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringList cityObj = new StringList();
            cityObj.AddCity("New York");
            cityObj.AddCity("Tokyo");
            cityObj.AddCity("Baku");
            Console.WriteLine(cityObj["Baku"]); 
        }
    }
}
