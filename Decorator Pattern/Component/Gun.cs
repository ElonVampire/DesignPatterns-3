using System;

namespace Decorator_Pattern
{
    internal abstract class Gun
    {
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract double GetDamage();
        public abstract int GetNoise();
        internal abstract string GetInfo();
    }
}