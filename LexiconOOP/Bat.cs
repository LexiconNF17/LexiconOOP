using System;

namespace LexiconOOP
{
    class Bat : Mammal, IFlying
    {
        public Bat(int weight) : base(weight)
        {
        }

        public bool IsFlying
        {
            get; private set;
        }

        public void Fly()
        {
            Console.WriteLine("The bat takes off...");
            IsFlying = true;
        }

        public void Land()
        {
            Console.WriteLine("The bat lands upside down on a branch.");
            IsFlying = false;
        }

        public override void Talk()
        {
            Console.WriteLine(Screech());
        }

        public string Screech()
        {
            return "screech";
        }
    }
}
