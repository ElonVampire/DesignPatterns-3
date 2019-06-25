using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessMan boss = new BusinessMan("Jeff");
            BusinessBuilder builder = new BusinessBuilder();
            boss.SetupNewBusiness()
        }
    }
}
