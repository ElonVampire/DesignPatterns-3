using Bridge_Pattern.Implementor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern.Abstraction
{
    class Tool
    {
        private IComboDeal _comboDeal;

        public Tool(IComboDeal comboDeal)
        {
            _comboDeal = comboDeal;
        }

        public void PrintComboDeal()
        {
            Console.WriteLine("Item Combo");
            Console.WriteLine("----------------------");
            foreach(Item anItem in _comboDeal.GetItems())
            {
                Console.WriteLine(anItem.Name);
                Console.WriteLine(anItem.Price);
                Console.WriteLine("......................");
            }
        }
    }
}
