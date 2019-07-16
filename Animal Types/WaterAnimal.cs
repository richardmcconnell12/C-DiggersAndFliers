using System;

namespace Animals
{
    public class WaterAnimal : Animal, ISwimmer
    {
        public int MaxDepth { get; set; }

        public string Speed { get; set; }

        public void Swim()
        {
            Console.WriteLine($"{Name} is now swimming.");
        }
    }
}