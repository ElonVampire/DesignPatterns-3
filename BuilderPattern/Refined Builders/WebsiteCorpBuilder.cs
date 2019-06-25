using BuilderPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern.Refined_Builders
{
    class WebsiteCorpBuilder : BusinessBuilder
    {
        public override void SetIndustry()
        {
            _business.SetIndustry("Technology");
        }

        public override void SetName()
        {
            _business.SetName("Website Corp");
        }

        public override void SetRevenue()
        {
            _business.SetRevenue(10000);
        }
    }
}
