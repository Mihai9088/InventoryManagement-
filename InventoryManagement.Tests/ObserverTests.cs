using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Tests
{
    [TestFixture]
    public class ObserverTests
    {
        private InventoryManager _inventoryManager;
        private TestObserver _testObserver;

        [SetUp]
        public void Setup()
        {
            _inventoryManager = InventoryManager.Instance; 
            _testObserver = new TestObserver();
            _inventoryManager.Attach(_testObserver);
        }

        [Test]
        public void AddItem_CallsUpdateOnObserver_WithCorrectMessage()
        {
            // Arrange
            var newItem = new BookItem("Effective Java", "Joshua Bloch", 1);

            // Act
            _inventoryManager.AddItem(newItem);

            // Assert
            Assert.AreEqual(1, _testObserver.UpdateCount);
            Assert.AreEqual("🆕 Item added 🆕", _testObserver.LastMessage);
        }

        [Test]
        public void RemoveItem_CallsUpdateOnObserver_WithCorrectMessage()
        {
            // Arrange
            var newItem = new BookItem("Effective Java", "Joshua Bloch", 1);
            _inventoryManager.AddItem(newItem);

            // Act
            _inventoryManager.RemoveItem(newItem);

            // Assert
            Assert.AreEqual(2, _testObserver.UpdateCount);
            Assert.AreEqual("🗑  Item removed 🗑", _testObserver.LastMessage);
        }
    }

}
