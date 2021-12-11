using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace byt_game.Models
{
    class CreditCardPayment : PaymentMethod
    {
        [Required]
        [MaxLength(16)]
        public string CreditCardNumber { get; }

        public CreditCardPayment(string number)
        {
            CreditCardNumber = number;
        }
    }
}