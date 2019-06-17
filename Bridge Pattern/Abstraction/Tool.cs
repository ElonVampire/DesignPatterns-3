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

        }
    }
}
