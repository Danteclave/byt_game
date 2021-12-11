using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    abstract class User
    {
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        [Required]
        [MaxLength(40)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public DateTime Birthday_Date { get; set; }
        [Required]
        [MaxLength(15)]
        public string Contact_number { get; set; }

        abstract public string Login();

        static public string Register()
        {
            return "User just registered";
        }
    }
}
