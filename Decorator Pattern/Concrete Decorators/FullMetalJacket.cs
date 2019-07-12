using Decorator_Pattern.Decorator;
using System;

namespace Decorator_Pattern
{
    class FullMetalJacket : GunDecorator
    {

        public FullMetalJacket(Gun gun) : base(gun)
        {
            Description = "with full metal jacket rounds";
            Damage = 100;
            Noise = 50;
        }

        public override string GetDescription()
        {
            return String.Format("{0} {1}", _gun.GetDescription(), Description);
        }

        public override double GetDamage()
        {
            return _gun.Damage + Damage;
        }

        public override int GetNoise()
        {
            return _gun.Noise + Noise;
        }

        public override string GetInfo()
        {
            return string.Format(
                "This is a {0}. \n" +
                "It does {1} damage and puts out {2} decibels of sound per shot.\n" +
                "This weapon can hold a total of {3} rounds in the magazine plus one in the chamber\n\n",
                GetDescription(),
                GetDamage(), GetNoise(),
                GetMagazineCapacity());
        }
    }
}