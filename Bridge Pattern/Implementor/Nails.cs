using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern.Implementor
{
    class Nails : IComboDeal
    {
        public List<Item> _myItems { get; set; }

        public Nails()
        {
            _myItems = new List<Item> {
                new Item {
                    Name = "Nails",
                    Price = 0.20f,
                    Description = "A pack of normal nails"
                },
                new Item {
                    Name = "Golden Nails",
                    Price = 50.40f,
                    Description = "a pack of golden nails?!"
                }
            };
        }
        public List<Item> GetItems()
        {
            return _myItems;
        }
    }
}
