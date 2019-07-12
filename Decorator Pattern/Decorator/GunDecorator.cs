using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern.Decorator
{
    class GunDecorator : Gun
    {

        protected Gun _gun;

        public GunDecorator(Gun gun)
        {
            _gun = gun;
        }

        public override double GetDamage()
        {
            return _gun.GetDamage();
        }

        public override string GetDescription()
        {
            return _gun.GetDescription();
        }

        public override int GetNoise()
        {
            return _gun.GetNoise();
        }

        public override string GetInfo()
        {
            return _gun.GetInfo();
        }

        public override int GetMagazineCapacity()
        {
            return _gun.GetMagazineCapacity();
        }
    }
}
