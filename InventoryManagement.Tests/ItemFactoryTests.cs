using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Tests
{
    [TestFixture]
    public class ItemFactoryTests
    {
        private ItemFactory _factory;

        [SetUp]
        public void SetUp()
        {
            _factory = new ItemFactory();
        }

        [Test]
        public void CreateItem_ReturnsBookItem_WhenTypeIsBook()
        {
            var item = _factory.CreateItem("book", "Design Patterns", 1, "Gamma et al");

            Assert.IsInstanceOf<BookItem>(item, "Factory should return a BookItem when type is 'book'.");
            var bookItem = item as BookItem;
            Assert.AreEqual("Design Patterns", bookItem.Name);
            Assert.AreEqual("Gamma et al", bookItem.Author);
        }

        [Test]
        public void CreateItem_ReturnsFurnitureItem_WhenTypeIsFurniture()
        {
            var item = _factory.CreateItem("furniture", "Office Desk", 5, "Wood");

            // 
            Assert.IsInstanceOf<FurnitureItem>(item, "Factory should return a FurnitureItem when type is 'furniture'.");
            var furnitureItem = item as FurnitureItem;
            Assert.AreEqual("Office Desk", furnitureItem.Name);
            Assert.AreEqual("Wood", furnitureItem.Material);
        }
    }
}
