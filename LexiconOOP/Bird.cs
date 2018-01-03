using System;

namespace LexiconOOP
{
    class Bird : Animal, IFlying
    {
      
        public bool IsFlying {
            get; private set;
        }

        public void Fly()
        {
            Console.WriteLine("The bird takes off...");
            IsFlying = true;
        }

        public void Land() {
            Console.WriteLine("The bird lands on a branch.");          
            IsFlying = false;
        }

        public override void Talk()
        {
            Console.WriteLine("tweet");
        }
    }
}
