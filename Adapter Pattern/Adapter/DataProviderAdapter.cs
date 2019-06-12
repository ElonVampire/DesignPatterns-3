using Adapter_Pattern.Client;

namespace Adapter_Pattern
{
    public class DataProviderAdapter : IInformationAdapter
    {
        private DataProvider _adaptee = new DataProvider();

        public string GetDataOperation()
        {
            return _adaptee.RetrieveTheData();
        }
    }
}