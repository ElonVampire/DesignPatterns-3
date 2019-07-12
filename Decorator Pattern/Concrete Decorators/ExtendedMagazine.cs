using Decorator_Pattern.Decorator;
using System;

namespace Decorator_Pattern
{
    class ExtendedMagazine : GunDecorator
    {

        public ExtendedMagazine(Gun gun )
            : base(gun)
        {
            Description = "extendo";
            MagazineCapacity = 10;
        }

        public override string GetDescription()
        {
            return String.Format("{0} {1}", Description, _gun.GetDescription());
        }

        public override int GetMagazineCapacity()
        {
            return _gun.GetMagazineCapacity() + MagazineCapacity;
        }

        public override string GetInfo()
        {
            return string.Format(
                "This is an {0}. \n" +
                "It does {1} damage and puts out {2} decibels of sound per shot.\n" +
                "This weapon can hold a total of {3} rounds in the magazine plus one in the chamber\n\n",
                GetDescription(),
                GetDamage(), GetNoise(),
                GetMagazineCapacity());
        }
    }
}