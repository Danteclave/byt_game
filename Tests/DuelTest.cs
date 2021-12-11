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
    public class DuelTest
    {
        [Fact]
        public void DuelConstructorTest()
        {
            Duel duel = new Duel(new Player(), new Player(), true, 10);
            Assert.NotNull(duel.HomePlayer);//if the constructor fails then this field would remain null
        }

        [Fact]
        public void DuelConstrainsTest()
        {
            ICollection<ValidationResult> results = new List<ValidationResult>();
            Duel duel = new Duel(new Player(), new Player(), true, 10);
            Assert.True(Validator.TryValidateObject(duel, new ValidationContext(duel), results, true));//everything is set correctly so the validator should return true
        }
    }
}
