using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class Player : User
    {
        long RankingPoints { get; set; }


        ICollection<Player> getFriends()
        {
            return friends;
        }

        void openMailbox()
        {
            ;
        }

        void InviteToTrade(Player other, Item item, int count)
        {
            ;
        }

        public ICollection<Player> friends;
    }
}
