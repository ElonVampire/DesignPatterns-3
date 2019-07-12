namespace Decorator_Pattern
{
    internal class UMP45 : Gun
    {
        public UMP45()
        {
            Description = "UMP .45";
            Damage = 500.50;
            Noise = 120;
            MagazineCapacity = 25;
        }

        public override double GetDamage()
        {
            return Damage;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override int GetNoise()
        {
            return Noise;
        }

        public override string GetInfo()
        {
            return string.Format(
                "This is a {0}. \n" +
                "It does {1} damage and puts out {2} decibels of sound per shot.\n" +
                "This weapon can hold a total of {3} rounds in the magazine plus one in the chamber\n\n",
                Description,
                Damage, Noise,
                GetMagazineCapacity());
        }

        public override int GetMagazineCapacity()
        {
            return MagazineCapacity;
        }
    }
}