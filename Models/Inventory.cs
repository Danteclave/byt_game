using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class Inventory
    {
        [Required]
        [Range( 0, 100)]
        public long GoldAmount { get; set; }

        [Required]
        [Range(0, 100)]
        public long DiamondsAmount { get; set; }

        [Required]
        public ICollection<InventoryItem> items;

        
    }
}
