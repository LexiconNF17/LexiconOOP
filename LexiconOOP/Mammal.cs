using System;

namespace LexiconOOP
{
    class Mammal : Animal
    {
        public int Weight { get; set; }
        public Mammal(int weight)
        {
            Weight = weight;
        }

        public override void Talk()
        {
            Console.WriteLine("I'm a mammal");
        }

        public override string ToString()
        {
            return base.ToString() + ": " + Weight + " kg";
        }
    }
}
