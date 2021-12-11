using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class Transaction
    {
        public Transaction(Decimal price, long diamondsBought, PaymentMethod paymentMethod)
        {
            this.price = price;
            this.diamondsBought = diamondsBought;
            date = DateTime.Now;
            this.paymentMethod = paymentMethod;
        }
        [Required]
        public readonly DateTime date;

        [Required]
        [Range(0, 1000)]
        public readonly Decimal price; //Decimal because we don't want silly rounding errors with normal floats/doubles

        [Required]
        [Range(0, 1000000)]
        public readonly long diamondsBought;

        PaymentMethod paymentMethod;
    }
}
