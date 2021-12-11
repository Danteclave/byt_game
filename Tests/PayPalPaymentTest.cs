using byt_game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace byt_game.Tests
{
    public class PayPalPaymentTest
    {
        public string username = "Spencer";

        PayPalPayment payment = new PayPalPayment("Spencer");

        [Fact]
        public void PayPalPaymentConstructorTest()
        {
            PayPalPayment newpayment = new PayPalPayment(username);
            Assert.NotNull(newpayment.PaypalUserName);
        }

        [Fact]
        public void PayPalPaymentGettersTest()
        {
            Assert.Equal(payment.PaypalUserName, username);
        }

        [Fact]
        public void PayPalPaymentConstraintsTest()
        {
            ICollection<ValidationResult> results = new List<ValidationResult>();
            PayPalPayment newPayment = new PayPalPayment("2635216338483562834823661842184");
            Assert.False(Validator.TryValidateObject(payment, new ValidationContext(payment), results, true));
        }
    }
}
