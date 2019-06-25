using BuilderPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern.Refined_Builders
{
    class BuyThingsRetailLimitedBuilder : BusinessBuilder
    {
        public override void SetIndustry()
        {
            _business.SetIndustry("Retail");
        }

        public override void SetName()
        {
            _business.SetName("Buy Things Retail");
        }

        public override void SetRevenue()
        {
            _business.SetRevenue(12000);
        }
    }
}
