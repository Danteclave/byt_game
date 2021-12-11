using byt_game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace byt_game.Tests
{
    public class MailboxTest
    {
        [Fact]
        public void ViewMailBoxTest()
        {
            Mailbox mailbox = new Mailbox();

            Mailbox sender = new Mailbox();
            Mailbox receiver = new Mailbox();
            Message message = new Message(sender, receiver, "content");
            mailbox.messages.Add(message);

            //check amount of messages in the MailBox
            Assert.Equal(1, mailbox.ViewMailBox().Count);

            //check the content of the message 
            Assert.Equal(message, mailbox.ViewMailBox().First());

        }
    }
}
