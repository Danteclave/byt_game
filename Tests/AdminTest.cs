using byt_game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace byt_game.Tests
{
    public class AdminTest
    {
        Player player = new();
        [Fact]
        public void AdminAddStrikeTest()
        {
            player.Username = "playerName";
            Assert.Equal("admin added a strike to the player playerName",Admin.AddStrike(player));
        }

        [Fact]
        public void AdminDeleteUserTest()
        {
            player.Username = "playerName";
            Assert.Equal("admin deleted the player playerName", Admin.DeleteUser(player));
        }

        [Fact]
        public void AdminAddAdminTest()
        {
            player.Username = "playerName";
            Assert.Equal("added player playerName as an admin", Admin.AddAdmin(player));
        }

        [Fact]
        public void AdminModifyUserTest()
        {
            player.Username = "playerName";
            Assert.Equal("admin modified the player playerName", Admin.ModifyUser(player));
        }
    }
}
