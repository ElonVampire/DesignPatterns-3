using System;

namespace BuilderPattern
{
    public abstract class BusinessBuilder
    {
        protected IBusiness _business;

        public void CreateBuisness()
        {
            _business = new Business();
        }

        public IBusiness GetBusiness()
        {
            return _business;
        }

        public abstract void SetName();
        public abstract void SetRevenue();
        public abstract void SetIndustry();
        
    }
}