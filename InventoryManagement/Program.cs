using InventoryManagement;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // singleton instance 
        var inventoryManager = InventoryManager.Instance;

        // attach the console observer to the inventory manager
        var consoleObserver = new ConsoleObserver();
        inventoryManager.Attach(consoleObserver);

        // create an instance of the factory
        IItemFactory itemFactory = new ItemFactory();

        var book1 = itemFactory.CreateItem("book", "Romania in WW2", 100, "George Orwell");
        var furniture1 = itemFactory.CreateItem("furniture", "Desk", 30, "Wood");

        inventoryManager.AddItem(book1);
        inventoryManager.AddItem(furniture1);

        var book2 = itemFactory.CreateItem("book", "C# Design Patterns", 10, "Mihai");
        var furniture2 = itemFactory.CreateItem("furniture", "Office Chair", 5, "Leather");
        var book3 = itemFactory.CreateItem("book", "C/C++", 100, "Bjarne Stroustrup");
        var furniture3 = itemFactory.CreateItem("furniture", "Living Chair", 54, "Plastic");

        inventoryManager.AddItem(book2);
        inventoryManager.AddItem(furniture2);
        inventoryManager.AddItem(book3);
        inventoryManager.AddItem(furniture3);

        inventoryManager.RemoveItem(book2);  
    }
}
