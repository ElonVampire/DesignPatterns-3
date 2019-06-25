using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessMan boss = new BusinessMan("Jeff");
            BusinessBuilder builder = new BusinessBuilder();
            builder.CreateBuisness();
            boss.SetupNewBusiness(builder.GetBusiness());
            boss.PrintMyBusinesses();
        }
    }
}
