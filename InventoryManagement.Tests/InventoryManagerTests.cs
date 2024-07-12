using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Tests
{
    [TestFixture]
    public class InventoryManagerTests
    {
        private InventoryManager _inventoryManager;

        [SetUp]
        public void Setup()
        {
            _inventoryManager = InventoryManager.Instance; 
        }

        [Test]
        public void AddItem_IncreasesItemCount()
        {
            var initialCount = _inventoryManager.GetItems().Count();
            var newItem = new BookItem(); 

            _inventoryManager.AddItem(newItem);

            Assert.AreEqual(initialCount + 1, _inventoryManager.GetItems().Count(), "Adding an item should increase item count.");
        }

        [Test]
        public void RemoveItem_DecreasesItemCount()
        {
            var initialCount = _inventoryManager.GetItems().Count();

            // Arrange
            var newItem = new BookItem("Test Book", "Author Test", 1);
            _inventoryManager.AddItem(newItem); 

            // Act
            _inventoryManager.RemoveItem(newItem); 

            // Assert
            Assert.AreEqual(initialCount, _inventoryManager.GetItems().Count(), "Removing an item should decrease item count.");
        }
    }
}
