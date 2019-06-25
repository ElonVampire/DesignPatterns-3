using Builder_Pattern.Refined_Builders;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessMan boss = new BusinessMan("Jeff");
            PortfolioBuilder portfolioBuilder = new PortfolioBuilder();
            portfolioBuilder.BuildPortfolio();
            boss.SetupPortfolio(portfolioBuilder.GetPortfolio());
            boss.PrintMyBusinesses();
        }
    }
}
