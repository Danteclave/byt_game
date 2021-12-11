using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class Trade
    {
        public Trade(TradeItem tradeItem, Player from, Player to)
        {
            this.tradeItem = tradeItem;
            date = DateTime.Now;
            this.sender = from;
            this.receiver = to;
        }

        [Required]
        public readonly TradeItem tradeItem;

        [Required]
        public readonly DateTime date;

        [Required]
        public readonly Player sender;

        [Required]
        public readonly Player receiver;
    }
}
