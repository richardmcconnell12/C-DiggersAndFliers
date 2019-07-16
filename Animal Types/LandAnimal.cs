using System;

namespace Animals
{
    public class LandAnimal : Animal, IWalker, IDigger
    {
        public int Speed { get; set; }

        public int NumberOfLegs { get; set; }

        public void Run()
        {
            Console.WriteLine($"{Name} is now running.");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is now walking.");
        }

        public void Dig()
        {
            Console.WriteLine($"{Name} is now digging.");
        }
    }
}