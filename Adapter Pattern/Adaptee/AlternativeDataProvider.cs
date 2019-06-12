using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern.Adaptee
{
    class AlternativeDataProvider
    {
        public string GetFirstWord()
        {
            return "This";
        }

        public string GetSecondWord()
        {
            return "is";
        }

        public string GetThirdWord()
        {
            return "a";
        }

        public string GetFourthWord()
        {
            return "weird";
        }

        public string GetFifthWord()
        {
            return "class";
        }
    }
}
