using System;
using Xunit;
using byt_game.Models;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace byt_game.Tests
{
    public class Tradetest
    {
        [Fact]
        public void TradeConsructorTest()
        {   //if the constructor fails then this field would remain null
            Trade item = new Trade(new TradeItem(new Item(), 10), new Player(), new Player() );
            Assert.NotNull(item);
        }

    }
}
