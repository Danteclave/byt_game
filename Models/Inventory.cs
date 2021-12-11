using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class Inventory
    {
        public long GoldAmount { get; set; }
        public long DiamondsAmount { get; set; }

        public ICollection<InventoryItem> items;
    }
}
