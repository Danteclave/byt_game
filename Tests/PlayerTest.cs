using byt_game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace byt_game.Tests
{
    //[TestClass]
    public class PlayerTest
    {
        Player player = new Player();

        [Fact]
        public void PlayerLoginTest()
        {
            string result = player.Login();
            Assert.Equal("player just logged in", result);
        }
    }
}
