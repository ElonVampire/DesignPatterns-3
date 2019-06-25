namespace BuilderPattern
{
    public interface IBusiness
    {
        string GetName();
        int GetRevenue();
        string GetIndustry();

        void SetName(string aName);
        void SetRevenue(int aRevenue);
        void SetIndustry(string anIndustry);
    }
}