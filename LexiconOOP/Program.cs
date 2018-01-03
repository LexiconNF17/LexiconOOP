using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Overriding();
            Pause();
            Casting();
            Pause();
            Talkers();
            Pause();
            Flyers();
            Pause();
        }

        private static void Pause()
        {
            Console.ReadKey(intercept: true);
            Console.Clear();
        }

        private static void Overriding()
        {
            object obj = new Object();

            var animal = new Mammal(weight: 4);

            // ctor 1
            var cat = new Cat("Leo", 5);

            // ctor 2
            var tom = new Cat(
                name: "Tom",
                weight: 5,
                breed: "angora");

            // In this case, WriteLine accepts an Object or a String. 
            // If it's an Object it performs .ToString() on it.
            Console.WriteLine(obj);
            Console.WriteLine(animal);
            Console.WriteLine(tom);
        }

        private static void Casting()
        {
            Mammal myPet = new Cat("Misha", 4, "rysk skogskatt");
            Console.WriteLine("myPet: " + myPet);

            // Breed is a property of Cat only
            Cat myCat = myPet as Cat;
            myCat.Breed = "sibirisk skogskatt";
            Console.WriteLine("myCat: " + myCat);

            Dog myDog = myPet as Dog; // will return a null object
            Console.WriteLine("myDog: " + myDog);
        }

        private static void Talkers()
        {
            var myPets = new List<Animal>
            {
                new Cat("Misha", 4, "rysk skogskatt"),
                new Dog(12),
                new Bat(1)
            };
            foreach (var pet in myPets)
            {
                Console.WriteLine(pet);

                // Weight is property of Mammal
                var mammal = pet as Mammal; // null if non-mammal
                if (mammal != null) mammal.Weight++;
                Console.WriteLine(mammal);

                // will call the most specific implementation (override) of Talk.
                pet.Talk();

                string sound = "";
                if (pet is Cat)
                {
                    // unsafe cast, ok because previous check
                    sound = ((Cat)pet).Meow();
                }
                else if (pet is Dog dog)
                {
                    // safe cast
                    sound = (pet as Dog).Woof();
                }
                else if (pet is Bat myBat)
                {

                    sound = myBat.Screech();
                }

                Console.WriteLine($"The animal's sound is '{sound}'");
                Console.WriteLine();
            }
        }


        private static void Flyers()
        {
            List<IFlying> flyers = new List<IFlying>
            {
                new Bat(1),
                new Bird()
            };
            foreach (var flyer in flyers)
            {
                Console.WriteLine(flyer);

                flyer.Fly();
                Console.WriteLine("It's " + (flyer.IsFlying ? "flying" : "resting"));

                flyer.Land();
                Console.WriteLine("It's " + (flyer.IsFlying ? "flying" : "resting"));

                // No access to Talk, despite implementations
                // flyer.Talk(); 

                Console.WriteLine();
            }
        }

    }
}
