using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class PaymentMethod
    {
        [Required]
        [MaxLength(25)]
        public string paymentDescription { get; set; }
    }
}