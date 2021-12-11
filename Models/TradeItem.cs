using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class TradeItem
    {
        [Required]
        public Item item { get; set; }

        [Required]
        [Range(minimum: 0, maximum: 100)]
        public int count { get; set; }

        public TradeItem(Item items, int counts)
        {
            count = counts;
            item = items;
        }
    }
}
