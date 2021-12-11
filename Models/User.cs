using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    abstract class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Birthday_Date { get; set; }
        public string Contact_number { get; set; }

        abstract public string Login();

        static public string Register()
        {
            return "User just registered";
        }
    }
}
