using System;

namespace Animals
{
    public class FlyAnimal : Animal, IFlier, IWalker
    {
        public int MaxHeight { get; set; }

        public string WingLength { get; set; }

        public void Fly()
        {
            Console.WriteLine($"{Name} is now flying.");
        }

        public void Run()
        {
            Console.WriteLine($"{Name} is now running.");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is now walking.");
        }
    }
}