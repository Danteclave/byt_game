using byt_game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace byt_game.Tests
{
    public class MessageTest
    {
        Mailbox sender = new Mailbox();
        Mailbox receiver = new Mailbox();
        string content = "The content of the message";

        [Fact]
        public void MessageConstructorsTest ()
        {
            Message message = new Message(sender, receiver, content);
            Assert.NotNull(message); //if the constructor fails then this field would remain null
        }

        [Fact]
        public void MessageConstraintTest()
        {
            Message message = new Message(sender, receiver,
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus hendrerit magna quis commodo finibus. Nullam tellus est, dignissim in dui id, sagittis bibendum ligula. Nunc euismod pharetra odio, ornare tempor ante bibendum sed. Phasellus et porta tellus. Donec quis urna dignissim risus tempus hendrerit. Proin porta tortor mauris, sed tempus risus semper quis. Vivamus nec vulputate velit, non finibus leo. Morbi sapien nunc, commodo sit amet accumsan venenatis, blandit gravida elit. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Suspendisse ligula nibh, imperdiet quis malesuada at, placerat quis magna. Curabitur orci quam, tincidunt non dignissim ac, dictum ac mauris. Vivamus a vehicula massa." +
                "In a nisl metus. Maecenas sed nisi vitae magna tristique pharetra. Ut in felis non velit vehicula aliquam. Praesent ac elementum nisi, non gravida arcu. Sed tincidunt consequat mauris id vulputate. Suspendisse sed fermentum enim. Phasellus erat est, eleifend a posuere nec, porttitor non risus. Nullam ullamcorper convallis ante at cursus." +
                "Quisque semper urna vel maximus sagittis. Quisque dictum commodo justo, eu volutpat metus feugiat ac. Ut convallis, ipsum sit amet ornare aliquet, sem mi luctus nisl, nec maximus tortor libero varius mi. Nam vel turpis metus. Aliquam tincidunt viverra tellus ut accumsan. Nulla facilisi. Aenean in tincidunt metus. Aliquam pharetra ex ut neque posuere convallis." +
                "Nam scelerisque velit ligula, in rhoncus nunc auctor viverra. Praesent sagittis arcu et tempus imperdiet. Ut facilisis leo eu mi maximus imperdiet. Proin vel erat sit amet nunc egestas mollis in a urna. Nam iaculis commodo iaculis. Nunc at sapien ultricies, rutrum nisl varius, lacinia sapien. Curabitur et lectus condimentum est fermentum porta eget eu augue. Integer eget sem at elit aliquam ultrices sed ac nulla."
                );
            ICollection<ValidationResult> results = new List<ValidationResult>();

            //everything is set correctly so the validator should return true
            Assert.False(Validator.TryValidateObject(message, new ValidationContext(message), results, true));
            Console.WriteLine(results);
           
        }

        [Fact]
        public void DeleteMessageTest()
        {
            Message message = new Message(sender, receiver, content);
            Assert.Equal("Message: The content of the message /is deleted", message.DeleteMessage(message));

        }

        [Fact]
        public void SendMessageTest()
        {
            Message oldMessage = new Message(sender, receiver, "new content");

            //Will return true since sendMessage creates a new instance of message 
            Assert.NotEqual( oldMessage, Message.sendMessage(sender, receiver, "new content"));
        }

    }
}
