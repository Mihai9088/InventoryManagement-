using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public abstract class Item : IItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public abstract void DisplayDetails();


    }
}
