using byt_game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace byt_game.Tests
{
    public class PaymentMethodTest
    {
        public string paymentDescription = "PayPal";

        PaymentMethod payment = new PaymentMethod();

        [Fact]
        public void PaymentMethodGettersSettersTest()
        {
            //PaymentMethod newpayment = new PaymentMethod();
            payment.paymentDescription = "PayPal";
            Assert.Equal(paymentDescription, payment.paymentDescription);
            //Assert.NotNull(payment.paymentDescription);
        }

        [Fact]
        public void PaymentMethodConstraintsTest()
        {
            ICollection<ValidationResult> results = new List<ValidationResult>();
            payment.paymentDescription = "This is a damn long description.";
            Assert.False(Validator.TryValidateObject(payment,new ValidationContext(payment),results,true));
        }
    }
}
