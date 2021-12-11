using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class Message
    {
        [Required]
        public readonly Mailbox sender;
        [Required]
        public readonly Mailbox receiver;
        [Required]
        [MaxLength(20)]
        public readonly string contents;
        
        public Message(Mailbox sender, Mailbox receiver, string contents)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.contents = contents;
        }

       
        public static Message sendMessage(Mailbox from, Mailbox to, string contents)
        {
            // ...
            return new Message(from, to, contents);
        }

        public string DeleteMessage(Message message)
        {
           return  $"Message: {message.contents} /is deleted";
        }
    }
}
