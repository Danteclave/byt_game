using System;
using System.Collections.Generic;
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
        public readonly DateTime date;
        public readonly Decimal price; // Decimal because we don't want silly rounding errors with normal floats/doubles
        public readonly long diamondsBought;

        PaymentMethod paymentMethod;
    }
}
