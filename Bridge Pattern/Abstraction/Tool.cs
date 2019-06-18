using Bridge_Pattern.Implementor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern.Abstraction
{
    class Tool
    {
        private IComboDeal _comboDeal;
        protected Item _primaryItem;

        public Tool(IComboDeal comboDeal)
        {
            _comboDeal = comboDeal;
        }

        public void PrintComboDeal()
        {
            Console.WriteLine("========================");
            Console.WriteLine(string.Format("Primary Item: {0}", _primaryItem.Name));
            Console.WriteLine(string.Format("Cost: {0}", _primaryItem.Price));
            Console.WriteLine("----------------------");
            foreach(Item anItem in _comboDeal.GetItems())
            {
                Console.WriteLine(string.Format("Item name: {0}", anItem.Name));
                Console.WriteLine(string.Format("Item price: {0}", anItem.Price));
                Console.WriteLine("......................");
            }
        }
    }
}
