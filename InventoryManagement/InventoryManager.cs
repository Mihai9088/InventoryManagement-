using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class InventoryManager
    {
        private static InventoryManager _instance;
        private List<IItem> _items;
        private IObserver _observer; 

        private InventoryManager()
        {
            _items = new List<IItem>();
        }

        public static InventoryManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InventoryManager();
                }
                return _instance;
            }
        }

        public void Attach(IObserver observer)
        {
            _observer = observer; 
        }

        public void Detach()
        {
            _observer = null; 
        }

        public void Notify(string message)
        {
            _observer?.Update(message);
        }
        public void AddItem(IItem item)
        {
            _items.Add(item);
            Notify("🆕 Item added 🆕");
        }

        public void RemoveItem(IItem item)
        {
            _items.Remove(item);
            Notify("🗑  Item removed 🗑");
        }

        public IEnumerable<IItem> GetItems()
        {
            return _items.AsReadOnly();
        }
    }

}
