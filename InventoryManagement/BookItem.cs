using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class BookItem : Item
    {
        public string Author { get; private set; }

        public BookItem() { }
        public BookItem(string name, string author, int quantity)
        {
            Name = name;
            Author = author;
            Quantity = quantity;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Book: {Name}, Author: {Author}, Quantity: {Quantity}");
        }
    }
}
