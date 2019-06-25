namespace BuilderPattern
{
    public class BusinessMaker
    {
        protected readonly BusinessBuilder _builder;

        public BusinessMaker(BusinessBuilder aBuilder)
        {
            _builder = aBuilder;
        }

        public void BuildBusiness()
        {
            _builder.CreateBuisness();
            _builder.SetName();
            _builder.SetRevenue();
            _builder.SetIndustry();
        }

        public IBusiness GetBusiness()
        {
            return _builder.GetBusiness();
        }
            
    }
}