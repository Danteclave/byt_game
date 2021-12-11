using System;
using Xunit;
using byt_game.Models;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace byt_game.Tests
{
    public class InventoryItemTest
    {
        public long count = 20;
        Item item = new Item();
        InventoryItem inventoryItem = new InventoryItem(new Item(), 10);

        [Fact]
        public void InventoryGettersAndSetterTest()
        {
            inventoryItem.count = 20;
            Assert.Equal(inventoryItem.count, count);
          
        }

        [Fact]
        public void InventoryConsructorTest()
        {   //if the constructor fails then this field would remain null
            InventoryItem inventoryItem1 = new InventoryItem(new Item(), 10);
            Assert.NotNull(inventoryItem1);
        }

        [Fact]
        public void InventoryItemConstraintTest()
        {
            ICollection<ValidationResult> results = new List<ValidationResult>();
            InventoryItem inventoryItem1 = new InventoryItem(new Item(), 10);
            inventoryItem1.count = 150;
            Assert.False(Validator.TryValidateObject(inventoryItem1, new ValidationContext(inventoryItem1), results, true));



        }



    }
}
