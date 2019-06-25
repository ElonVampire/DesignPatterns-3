using BuilderPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern.Refined_Builders
{
    class EatFoodTavernBuilder : BusinessBuilder
    {
        public override void SetIndustry()
        {
            _business.SetIndustry("Hospitality");
        }

        public override void SetName()
        {
            _business.SetName("Eat Food Tavern");
        }

        public override void SetRevenue()
        {
            _business.SetRevenue(3000);
        }
    }

}
