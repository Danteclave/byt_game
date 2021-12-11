using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public readonly Player HomePlayer;
        [Required]
        public readonly Player GuestPlayer;
        [Required]
        public readonly DateTime Date;
        /// <summary>
        /// true if home won, false otherwise
        /// </summary>
        [Required]
        public readonly bool Winner;
        [Required]
        public readonly long RankingPointsChange;
    }
}
