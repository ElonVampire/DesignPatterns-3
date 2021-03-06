using System;

namespace Decorator_Pattern
{
    internal abstract class Gun
    {
        public string Description { get; set; }
        public double Damage { get; set; }
        public int Noise { get; set; }
        public int MagazineCapacity { get; set; }
        public abstract string GetDescription();
        public abstract double GetDamage();
        public abstract int GetNoise();
        public abstract int GetMagazineCapacity();
        public abstract string GetInfo();
    }
}