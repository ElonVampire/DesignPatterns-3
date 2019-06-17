using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern.Implementor
{
    class Screws : IComboDeal
    {
        private List<Item> _myItems;

        public Screws()
        {
            _myItems = new List<Item> {
                new Item {
                    Name = "Philips head screw",
                    Price = 0.50f,
                    Description = "a pack of philips head screws"
                },
                new Item {
                    Name = "Flat head screw",
                    Price = 0.40f,
                    Description = "a pack of flat head screws"
                }
            };
        }
        public List<Item> GetItems()
        {
            return _myItems;
        }
    }
}
