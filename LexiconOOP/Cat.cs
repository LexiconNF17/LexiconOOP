using System;

namespace LexiconOOP
{
    class Cat : Mammal
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public Cat(string name, int weight) : base(weight + 1)
        {
            // weight är redan hanterat av Animal(weight)  
            Name = name;
        }
        public Cat(string name, int weight, string breed) : this(name, weight)
        {
            // name och weight är redan hanterat av Cat(name, weight)
            Breed = breed;
        }

        public override string ToString()
        {
            return base.ToString() + $", {Name} ({Breed})";
        }

        public override void Talk()
        {
            Console.WriteLine(Meow());
        }

        public string Meow()
        {
            return "meow";
        }
    }
}
