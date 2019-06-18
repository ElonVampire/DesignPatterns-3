using System;
using System.Collections.Generic;
using System.Text;
using Bridge_Pattern.Implementor;

namespace Bridge_Pattern.Abstraction
{
    class Hammer : Tool
    {

        public Hammer(IComboDeal comboDeal) : base(comboDeal)
        {
            _primaryItem = new Item
            {
                Name = "Hammer",
                Price = 5.0f,
                Description = "Hits things well"
            };
        }

    }
}
