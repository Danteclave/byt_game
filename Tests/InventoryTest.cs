using System;
using Xunit;
using byt_game.Models;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace byt_game.Tests
{
    public class InventoryTest
    {
       

        public long goldAmount = 10;
        public long diamondsAmount = 30;

        Inventory inventory = new Inventory();

        [Fact]
        public void InventoryConstraintTest()
        {
            ICollection<ValidationResult> results = new List<ValidationResult>();
            Inventory inventory1 = new Inventory();
            inventory1.GoldAmount = 150;
            inventory1.DiamondsAmount = 250;
            Assert.False(Validator.TryValidateObject(inventory1, new ValidationContext(inventory1), results, true));

           

        }

        [Fact]
        public void InventoryGettersAndSetterTest()
        {

            inventory.GoldAmount = goldAmount;
            inventory.DiamondsAmount = diamondsAmount;
            Assert.Equal(inventory.GoldAmount, goldAmount);
            Assert.Equal(inventory.DiamondsAmount, diamondsAmount);



        }


    }
}
