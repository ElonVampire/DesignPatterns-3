using System;
using System.Collections.Generic;
using System.Text;
using Bridge_Pattern.Implementor;

namespace Bridge_Pattern.Abstraction
{
    class Hammer : Tool
    {
        private Item _primaryItem;

        public Hammer(IComboDeal comboDeal) : base(comboDeal)
        {
            _primaryItem = new Item
            {
                Name = "Hammer",
                Price = 5.0f,
                Description = "Hits things well"
            };
        }

        public new void PrintComboDeal()
        {
            Console.WriteLine("========================");
            Console.WriteLine(string.Format("Primary Item: {0}", _primaryItem.Name)); 
            Console.WriteLine(string.Format("Cost: {0}", _primaryItem.Price)); 
            base.PrintComboDeal();
        }
    }
}
