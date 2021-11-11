using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class Message
    {
        public readonly Mailbox sender;
        public readonly Mailbox receiver;
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

        public static void DeleteMessage(Message message)
        {
            ;
        }
    }
}
