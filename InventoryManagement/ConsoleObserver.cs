using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class ConsoleObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Inventory has been updated: {message}");
            foreach (var item in InventoryManager.Instance.GetItems())
            {
                item.DisplayDetails();
            }
            Console.WriteLine("\n");
        }
    }
}
