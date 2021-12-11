using byt_game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace byt_game.Tests
{
    public class TransactionTest
    {
        public Decimal price = 900;
        public long diamondsBought = 1000;

        Transaction transaction = new Transaction(900, 1000, new PaymentMethod());

        [Fact]
        public void TransactionConstructorTest()
        {
            Transaction newpayment = transaction;//set
            Assert.NotNull(newpayment);//get
        }
        
        [Fact]
        public void TransactionConstraintsTest()
        {
            Transaction transaction1 = new Transaction(900, 1000, new PaymentMethod());
            ICollection<ValidationResult> results = new List<ValidationResult>();
            Assert.True(Validator.TryValidateObject(transaction1, new ValidationContext(transaction1), results, true));
        }
    }
}