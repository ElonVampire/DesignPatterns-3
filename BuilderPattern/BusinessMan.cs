using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class BusinessMan
    {
        protected string Name;
        protected List<IBusiness> myBusinesses;

        public BusinessMan(string name)
        {
            Name = name;
            myBusinesses = new List<IBusiness>();
        }

        public void SetupNewBusiness(IBusiness aBusiness)
        {
            myBusinesses.Add(aBusiness);
            Console.Write(String.Format("The Business {0} was added successfully", aBusiness.GetName()));
        }

        public void PrintMyBusinesses()
        {
            int totalRevenue = 0;
            Console.WriteLine(String.Format("I am {0} and I own {1} businesses. \n These businesses are...", Name, myBusinesses.Count));
            Console.WriteLine("-----------------------------------------------");
            foreach(IBusiness aBusiness in myBusinesses)
            {
                Console.WriteLine(String.Format("Business name: {0} \n Revenue: {1} \n Industry: {2}",
                    aBusiness.GetName(),
                    aBusiness.GetRevenue().ToString(),
                    aBusiness.GetIndustry()
                    )
                );
                totalRevenue += aBusiness.GetRevenue();
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(String.Format("In total I earn ${0} a year and it is great!", totalRevenue.ToString()));
        }
    }
}