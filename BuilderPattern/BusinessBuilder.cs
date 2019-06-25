using System;

namespace BuilderPattern
{
    public abstract class BusinessBuilder
    {
        protected IBusiness _business;

        public void CreateBuisness()
        {
            _business = new Business();
            SetName();
            SetRevenue();
            SetIndustry();
        }

        public abstract void SetName();
        public abstract void SetRevenue();
        public abstract void SetIndustry();
        public abstract IBusiness GetBusiness();
    }
}