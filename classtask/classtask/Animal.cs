using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask
{
    public class Animal
    {
        public string name;
        public int age;

        public void Eat()
        { 
            Console.WriteLine($"able to eat");
        }
    }
    public class Dog : Animal
    {

        public bool hasTail;

        public Dog(string name, int age, bool hasTail)
        {
            this.name = name;
            this.age = age; 
            this.hasTail = hasTail;

        }
        public void Bark() 
        {
            Console.WriteLine($"Dogs are Barking");
        }

        public void GetInfo()
        {
            Console.WriteLine($"New dogs name: {name} \nNew dogs age: {age} \nIs new dog has tail? : {hasTail}");
        }
    }
    public class Bear : Animal
    {
        public bool isWild;


        public Bear(string name, int age, bool isWild)
        {
            this.name = name;
            this.age = age;
            this.isWild = isWild;
        }
        public void GetInfo()
        {
            Console.WriteLine($"New Bears name: {name} \nNew Bears age: {age} \nIs new Bear is wild? : {isWild}");
        }
    }
    public class Bird : Animal
    {
        public bool CanSwim;
        public Bird(string name, int age, bool canSwim)
        {
            this.name = name;
            this.age = age;
            this.CanSwim = canSwim;
        }
        public void Fly()
        { 
            Console.WriteLine("Fly"); 
        }
        public void GetInfo()
        {
            Console.WriteLine($"New Birds name: {name} \nNew Birds age: {age} \nIs new Birds is wild? : {CanSwim}");
        }
    }
}
