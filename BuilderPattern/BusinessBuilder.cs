using System;

namespace BuilderPattern
{
    internal class BusinessBuilder
    {
        protected IBusiness _business;

        public BusinessBuilder()
        {
        }

        internal void CreateBuisness()
        {
            _business = new Business();
            SetName();
            SetRevenue();
            SetIndustry();
        }

        private void SetName()
        {
            _business.SetName("Website Corp");
        }

        private void SetRevenue()
        {
            _business.SetRevenue(10000);
        }

        private void SetIndustry()
        {
            _business.SetIndustry("Technology");
        }

        public IBusiness GetBusiness()
        {
            return _business;
        }
    }
}