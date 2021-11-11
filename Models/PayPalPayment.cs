using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class PayPalPayment
    {
        public string PaypalUserName { get; }
        public PayPalPayment(string username)
        {
            PaypalUserName = username;
        }
    }
}
