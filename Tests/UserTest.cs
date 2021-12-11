using byt_game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace byt_game.Tests
{
    public class UserTest
    {
        [Fact]
        public void UserConstraintsTest()
        {
            ICollection<ValidationResult> results = new List<ValidationResult>();
            Player tmp = new Player(); //using Player because it inherits from the User and user is an abstract class
            tmp.Username = "12345678dfgshjhfd9012314";
            tmp.Password = "sosfydgfdshjkasdkfjhgshaukfigeu";
            tmp.Email = "tfedaghudfsdusfdaujidegfyheaujgfajfgedajyhest@amogus.com";
            tmp.Contact_number = "1234567895246732584612735";
            Assert.False(Validator.TryValidateObject(tmp, new ValidationContext(tmp), results, true));//checking if the validation fails because every field is set to an incorrect value.
        }

        [Fact]
        public void UserRegiasterTest()
        {
            Assert.Equal("User just registered", User.Register());
        }
        
    }
}
