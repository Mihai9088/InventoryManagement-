using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    //factory design pattern
    public interface IItemFactory
    {
        IItem CreateItem(string type, string name, int quantity, string extraProperty = "");
    }
}
