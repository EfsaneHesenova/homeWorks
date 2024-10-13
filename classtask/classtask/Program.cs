using System.Linq.Expressions;

namespace classtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animalType;
            while (true) 
            {
                Console.WriteLine("Heyvan daxil edin:");
                animalType = Console.ReadLine();
                if (animalType == "Dog" || animalType == "Bear" || animalType == "Bird")
                {
                    if (animalType == "Dog")
                    {
                        string dogName;
                        int dogAge;
                        bool hasTail;
                        Console.Write($"What is your dog name: ");
                        dogName = Console.ReadLine();
                        Console.Write($"What is your dog age: ");
                        dogAge = int.Parse(Console.ReadLine());
                        Console.Write($"Is your dog has a tail: ");
                        hasTail = bool.Parse(Console.ReadLine());


                        Dog newDog = new Dog(dogName, dogAge, hasTail);
                        
                        newDog.GetInfo();
                        newDog.Bark();
                        newDog.Eat();
                        break;
                    }
                    else if (animalType == "Bear")
                    {
                        String BearName;
                        int BearAge;
                        bool isWild;
                        Console.Write($"What is your Bear name: ");
                        BearName = Console.ReadLine();
                        Console.Write($"What is your Bear age: ");
                        BearAge = int.Parse(Console.ReadLine());
                        Console.Write($"Is your Bear is a wild: ");
                        isWild = bool.Parse(Console.ReadLine());


                        Bear newBear = new Bear(BearName, BearAge, isWild);
                        newBear.GetInfo();
                        newBear.Eat();
                        break;
                    }
                    else if (animalType == "Bird")
                    {
                        String BirdName;
                        int BirdAge;
                        bool canSwim;
                        Console.Write($"What is your Bird name: ");
                        BirdName = Console.ReadLine();
                        Console.Write($"What is your Bird age: ");
                        BirdAge = int.Parse(Console.ReadLine());
                        Console.Write($"Is your Bird can a swim: ");
                        canSwim = bool.Parse(Console.ReadLine());


                        Bird newBird = new Bird(BirdName, BirdAge, canSwim);
                        newBird.GetInfo();
                        newBird.Fly();
                        newBird.Eat();
                        break;
                    }
                }
                else 
                {
                    Console.WriteLine("Please select only dog,bear or bird");
                    continue;
                }

            }
        }
    }
}
