using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class InventoryItem
    {
        public InventoryItem(Item item, long count)
        {
            this.item = item;
            this.count = count;
        }

        public readonly Item item;
        public long count { get; set; }
    }
}
