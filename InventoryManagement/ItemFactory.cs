using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class ItemFactory : IItemFactory
    {
        public IItem CreateItem(string type, string name, int quantity, string extraProperty = "")
        {
            switch (type.ToLower())
            {
                case "book":
                    return new BookItem(name, extraProperty, quantity);
                case "furniture":
                    return new FurnitureItem(name, extraProperty, quantity); 
                default:
                    throw new ArgumentException("Unknown item type");
            }
        }
    }
}
