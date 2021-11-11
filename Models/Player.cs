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
        }

        long RankingPoints { get; set; }

        ICollection<Player> getFriends()
        {
            return friends;
        }

        private readonly Inventory inventory;
        private readonly Mailbox mailbox;
        public Mailbox openMailbox()
        {
            return mailbox;
        }

        void InviteToTrade(Player other, Item item, int count)
        {
            ;
        }

        public ICollection<Player> friends;
        public ICollection<Duel> duels;
        public ICollection<Trade> trades;
        public ICollection<Transaction> transactions;
    }
}
