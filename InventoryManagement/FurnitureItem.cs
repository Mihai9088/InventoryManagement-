using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class FurnitureItem : Item
    {
        public string Material { get; private set; }
        public FurnitureItem() { }
        public FurnitureItem(string name, string material, int quantity)
        {
            Name = name;
            Material = material;
            Quantity = quantity;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Furniture: {Name}, Material: {Material}, Quantity: {Quantity}");
        }
    }
}
