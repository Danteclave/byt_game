using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byt_game.Models
{
    class Admin : Player
    {
        public static string AddStrike(Player player)
        {
            return $"admin added a strike to the player {player.Username}";
        }

        public static string DeleteUser(Player player)
        {
            return $"admin deleted the player {player.Username}";
        }

        public static string AddAdmin(Player player)
        {
            return $"added player {player.Username} as an admin";
        }

        public static string ModifyUser(Player player)
        {
            return $"admin modified the player {player.Username}";
        }
    }
}
