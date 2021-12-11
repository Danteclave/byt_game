using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class Duel
    {
        public Duel(Player home, Player guest, bool winner, long rankingpts)
        {
            HomePlayer = home;
            GuestPlayer = guest;
            Winner = winner;
            RankingPointsChange = rankingpts;
            Date = DateTime.Now;
        }
        public readonly Player HomePlayer;
        public readonly Player GuestPlayer;
        public readonly DateTime Date;
        /// <summary>
        /// true if home won, false otherwise
        /// </summary>
        public readonly bool Winner;
        public readonly long RankingPointsChange;
    }
}
