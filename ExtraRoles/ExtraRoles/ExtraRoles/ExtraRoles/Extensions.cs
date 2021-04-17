using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraRoles
{
    public static class Extensions
    {
        public static readonly Random rand = new Random();
        public static void SetRank(this ReferenceHub player, string rank, string color = "default")
        {
            player.serverRoles.NetworkMyText = rank;
            player.serverRoles.NetworkMyColor = color;
        }
        public static bool Chance(int percent)
        {
            int res = rand.Next(101);
            if (res <= percent) return true; else return false;
        }
    }
}
