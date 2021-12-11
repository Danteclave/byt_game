using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class Player : User
    {
        public Player()
        {
            mailbox = new Mailbox();
            inventory = new Inventory();
            RankingPoints = 0;
            friends = new List<Player>();
            duels = new List<Duel>();
            trades = new List<Trade>();
            transactions = new List<Transaction>();
        }

        long RankingPoints { get; set; }

        public ICollection<Player> getFriends()
        {
            return friends;
        }

        private readonly Inventory inventory;
        private readonly Mailbox mailbox;
        public Mailbox openMailbox()
        {
            return mailbox;
        }

        public string InviteToTrade(Player other, Item item, int count)
        {
            return $"{Username} just invited {other.Username} to trade.";
        }

        public override string Login()
        {
            return "player just logged in";
        }

        private ICollection<Player> friends;
        public ICollection<Duel> duels;
        public ICollection<Trade> trades;
        public ICollection<Transaction> transactions;
    }
}
