using Builder_Pattern.Refined_Builders;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class PortfolioBuilder
    {
        protected List<BusinessMaker> _portfolio;
        public PortfolioBuilder()
        {
             _portfolio = new List<BusinessMaker>();
        }

        public void BuildPortfolio()
        {
            BusinessMaker website = new BusinessMaker(new WebsiteCorpBuilder());
            BusinessMaker tavern = new BusinessMaker(new EatFoodTavernBuilder());
            BusinessMaker retail = new BusinessMaker(new BuyThingsRetailLimitedBuilder());

            _portfolio.Add(website);
            _portfolio.Add(tavern);
            _portfolio.Add(retail);
        }

        public List<BusinessMaker> GetPortfolio()
        {
            return _portfolio;
        }
    }
}