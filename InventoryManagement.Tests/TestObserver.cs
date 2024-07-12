using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Tests
{
    public class TestObserver : IObserver
    {
        public string LastMessage { get; private set; }
        public int UpdateCount { get; private set; }

        public void Update(string message)
        {
            LastMessage = message;
            UpdateCount++;
        }
    }
}
