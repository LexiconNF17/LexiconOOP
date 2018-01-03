using System;

namespace LexiconOOP
{
    class Dog : Mammal
    {
        public Dog(int weight) : base(weight) { }
        
        public new void Talk() // Hides base.Talk()
        {
            Console.WriteLine(Woof());
        }

        public string Woof()
        {
            return "woof";
        }      
    }
}
