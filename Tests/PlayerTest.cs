using byt_game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace byt_game.Tests
{
    public class PlayerTest
    {
        Player player = new Player();

        [Fact]
        public void PlayerConstructorTest()
        {
            Player newPlayer = new Player();
            Assert.NotNull(newPlayer.getFriends());
        }

        [Fact]
        public void PlayerLoginTest()
        {
            string result = player.Login();
            Assert.Equal("player just logged in", result);
        }

        [Fact]
        public void PlayerFriendsTest()
        {
            player.getFriends().Add(new Player());
            player.getFriends().Add(new Player());
            player.getFriends().Add(new Player());
            Assert.Equal(3,player.getFriends().Count);
        }

        [Fact]
        public void PlayerMailboxTest()
        {
            Mailbox mailbox = player.openMailbox();
            Assert.NotNull(mailbox);
        }
        [Fact]
        public void PlayerTradingTest()
        {
            player.Username = "player1";
            Player otherPlayer = new Player();
            otherPlayer.Username = "player2";
            Assert.Equal("player1 just invited player2 to trade.", player.InviteToTrade(otherPlayer, new Item(), 1));
        }
    }
}
