using System;
using System.Collections.Generic;
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
        public readonly TradeItem tradeItem;
        public readonly DateTime date;

        public readonly Player sender;
        public readonly Player receiver;
    }
}
