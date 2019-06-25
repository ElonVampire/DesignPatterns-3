namespace BuilderPattern
{
    public class Business : IBusiness
    {
        public string Name;
        public int Revenue;
        public string Industry; 

        public string GetIndustry()
        {
            return Industry;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetRevenue()
        {
            return Revenue;
        }

        public void SetIndustry(string anIndustry)
        {
            Industry = anIndustry;
        }

        public void SetName(string aName)
        {
            Name = aName;
        }

        public void SetRevenue(int aRevenue)
        {
            Revenue = aRevenue;
        }
    }
}