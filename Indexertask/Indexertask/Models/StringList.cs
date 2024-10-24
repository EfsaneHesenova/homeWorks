using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Indexertask.Models
{
    internal  class StringList
    {
        public  string[] cities;

        public StringList()
        {
            cities = new string[0];
        }
        public void AddCity(string city)
        {
            Array.Resize(ref cities, cities.Length+1);
            cities[^1] = city;
        }
        public int this[string cityName]
        {
            get
            {
                for (int i = 0; i < cities.Length; i++)
                {
                    if (cities[i] == cityName) { return i; }
                }
                return -1;
            }
        }
    }
    
}
