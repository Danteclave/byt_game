﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class CreditCardPayment
    {
        public string CreditCardNumber { get; }
        public CreditCardPayment(string number)
        {
            CreditCardNumber = number;
        }
    }
}