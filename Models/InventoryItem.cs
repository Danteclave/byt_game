using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        public readonly Item item;

        [Required]
        [Range(minimum: 0, maximum: 100)]
        public long count { get; set; }
    }
}
