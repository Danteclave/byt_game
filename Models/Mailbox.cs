using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class Mailbox
    {
        public IReadOnlyCollection<Message> ViewMailBox()
        {
            return (IReadOnlyCollection<Message>)messages;
        }


        public readonly ICollection<Message> messages;
    }
}