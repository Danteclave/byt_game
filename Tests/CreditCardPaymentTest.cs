using byt_game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace byt_game.Tests
{
    public class CreditCardPaymentTest
    {
        public string number = "5658565852145698";

        CreditCardPayment payment = new CreditCardPayment("5658565852145698");

        [Fact]
        public void PayPalPaymentConstructorTest()
        {
            CreditCardPayment newpayment = new CreditCardPayment(number);
            Assert.NotNull(newpayment.CreditCardNumber);
        }

        [Fact]
        public void PayPalPaymentGettersTest()
        {
            Assert.Equal(payment.CreditCardNumber, number);
        }

        [Fact]
        public void CreditCardPaymentConstraintsTest()
        {
            ICollection<ValidationResult> results = new List<ValidationResult>();
            CreditCardPayment newPayment = new CreditCardPayment("2635216338483562834t823661842184");
            Assert.False(Validator.TryValidateObject(newPayment, new ValidationContext(newPayment), results, true));
        }
    }
}
