using Adapter_Pattern.Adaptee;
using Adapter_Pattern.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern.Adapter
{
    class AlternativeDataProviderAdapter : IInformationAdapter
    {
        private AlternativeDataProvider _adaptee = new AlternativeDataProvider();

        public string GetDataOperation()
        {
            string result = "";
            result += _adaptee.GetFirstWord() + " ";
            result += _adaptee.GetSecondWord() + " ";
            result += _adaptee.GetThirdWord() + " ";
            result += _adaptee.GetFourthWord() + " ";
            result += _adaptee.GetFifthWord() + " ";
            return result;
        }
    }
}
