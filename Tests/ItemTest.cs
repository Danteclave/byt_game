using byt_game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace byt_game
{
    public class ItemTest
    {
        [Fact]
        public void ItemConstraintsTest()
        {
            ICollection<ValidationResult> results = new List<ValidationResult>();
            Item item = new Item();
            item.Name = "This name is longer than required";
            item.Description = "This description is a lot longer than required by the constraints";

            //checking if the validation fails because every field is set to an incorrect value.
            Assert.False(Validator.TryValidateObject(item, new ValidationContext(item), results, true));
        }
        [Fact]
        public void GetItemTest()
        {
            Item item = new Item();
            item.Name = "Item1";
            item.Description = "Description1";
            item.Image = "ImageUrl1";

            Assert.Equal("Item1", item.Name);
            Assert.Equal("Description1", item.Description);
            Assert.Equal("ImageUrl1", item.Image);
        }

    }
    
}
