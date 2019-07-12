using Decorator_Pattern.Concrete_Decorators;
using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun aGun = new UMP45();
            Gun silencedGun = new Silencer(aGun);
            Gun FMJsilencedGun = new FullMetalJacket(silencedGun);
            Gun silencedExtendedGun = new ExtendedMagazine(silencedGun);
            Gun extendedGun = new ExtendedMagazine(aGun);
            Gun FMJextendedGun = new FullMetalJacket(extendedGun);
            Console.WriteLine(aGun.GetInfo());
            Console.WriteLine(silencedGun.GetInfo());
            Console.WriteLine(FMJsilencedGun.GetInfo());
            Console.WriteLine(silencedExtendedGun.GetInfo());
            Console.WriteLine(extendedGun.GetInfo());
            Console.WriteLine(FMJextendedGun.GetInfo());
        }
    }
}
