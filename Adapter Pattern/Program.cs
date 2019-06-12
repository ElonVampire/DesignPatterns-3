using Adapter_Pattern.Adapter;
using Adapter_Pattern.Client;
using System;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new DataRenderer(new DataProviderAdapter())._information);
            Console.WriteLine(new DataRenderer(new AlternativeDataProviderAdapter())._information);
            
        }
    }
}
