using byt_game.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace byt_game
{
    public class ItemTest
    {
       public  string name = "hammer";
       public string description = "does 5 damage";
        public string image = "imageurl";

        Item item = new Item("hammer", "imageurl", "does 5 damage");

        [Fact]
        public void ItemconstructorsTest ()
        {
            Item newItem = new Item(name, description, image);
            Assert.NotNull(newItem.Name);
            Assert.NotNull(newItem.Description);
                Assert.NotNull(newItem.Image);
        }
        [Fact]
        public void ItemGettersTest()
        {
            Assert.Equal(item.Name,name);
            Assert.Equal(item.Description,description);
            Assert.Equal(item.Image,image);
        }

        [Fact]
        public void ItemSettersTest()
        {
            item.Name = "Sword";
            Assert.Equal("Hammer", item.Name);
        }


    }
    
}
