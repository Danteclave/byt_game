using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class Item
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        /// <summary>
        /// url to the image
        /// </summary>
        /// 
        [Required]
        public string Image { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

    }
}
