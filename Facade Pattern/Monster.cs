using System;

namespace Facade_Pattern
{
    public  class Monster
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Accuracy { get; set; }

        public void Examine()
        {
            Console.WriteLine($"Grrr! My name is {Name}. My stats are...\nHealth: {Health}\nStrength: {Strength}\nAccuracy: {Accuracy}");
        }
    }
}