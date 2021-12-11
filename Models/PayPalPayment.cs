using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class PayPalPayment : PaymentMethod
    {
        [Required]
        [MaxLength(10)]
        public string PaypalUserName { get; }

        public PayPalPayment(string username)
        {
            PaypalUserName = username;
        }
    }
}