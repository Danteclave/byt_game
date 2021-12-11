using System;
using Xunit;
using byt_game.Models;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace byt_game.Tests
{
    public class TradeItemTest
    {
        public long count = 30;
        TradeItem tradeItem= new TradeItem(new Item(), 20);

        [Fact]
        public void TradeItemGettersAndSetterTest()
        {
            tradeItem.count = 30;
            Assert.Equal(tradeItem.count, count);
            Item item1 = new Item();
            item1.Name = "Ulzhan";
            tradeItem.item = item1;
            Assert.Equal(item1,tradeItem.item);
            Assert.Equal("Ulzhan", tradeItem.item.Name);
            
        }

        [Fact]
        public void TradeItemConsructorTest()
        {   //if the constructor fails then this field would remain null
            TradeItem TradeItem1 = new TradeItem(new Item(), 10);
            Assert.NotNull(TradeItem1);
        }

        [Fact]
        public void TradeItemConstraintTest()
        {
            ICollection<ValidationResult> results = new List<ValidationResult>();
            TradeItem tradeItem1 = new TradeItem(new Item(), 10);
            tradeItem1.count = 150;
            Assert.False(Validator.TryValidateObject(tradeItem1, new ValidationContext(tradeItem1), results, true));



        }

    }
}
