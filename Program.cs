using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bear = new LandAnimal() { Name = "Bear" };
            var Tiger = new LandAnimal() { Name = "Tiger" };
            var Eagle = new FlyAnimal() { Name = "Eagle" };
            var Cardinal = new FlyAnimal() { Name = "Cardinal" };
            var Frog = new Amphibian() { Name = "Frog" };
            var Salamander = new Amphibian() { Name = "Salamander" };
            var Shark = new WaterAnimal() { Name = "Shark" };
            var StingRay = new WaterAnimal() { Name = "Sting Ray" };
            var EarthWorm = new LandAnimal() { Name = "Earth Worm" };
            var RattleSnake = new LandAnimal() { Name = "Rattle Snake" };

            var FlyContainer = new FlierContainer();
            FlyContainer.Fliers = new List<IFlier>() { Eagle, Cardinal };

            var SwimmerContainer = new SwimmerContainer();
            SwimmerContainer.Swimmers = new List<ISwimmer>() { Frog, Salamander, Shark, StingRay };

            var WalkerContainer = new WalkerContainer();
            WalkerContainer.Walkers = new List<IWalker>() { Bear, Tiger, Frog, Salamander, EarthWorm, RattleSnake };
        }
    }
}
