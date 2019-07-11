using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun myPrimaryGun = new UMP45();
            Gun mySecondaryGun = new USP40();

            Console.WriteLine(myPrimaryGun.GetInfo());
            Console.WriteLine(mySecondaryGun.GetInfo());
        }
    }
}
