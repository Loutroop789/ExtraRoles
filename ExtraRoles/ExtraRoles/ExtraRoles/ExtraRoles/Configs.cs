using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraRoles
{
    public static class Configs
    {
        public static bool extrarolesenable;
        public static List<int> d9341itms;
        public static List<int> scp181items;
        public static int d9341spawnChance;
        public static int scp181spawnChance;
        public static int d9341minplys;
        public static int scp181minplys;
        public static int scp181LuckyNumber;
        public static string d9341Description;
        public static string scp181Description;
        public static void Reload()
        {
           extrarolesenable = Qurre.Plugin.Config.GetBool("extra_roles_enable");
           d9341itms = Qurre.Plugin.Config.GetIntList("d9341items");
            d9341spawnChance = Qurre.Plugin.Config.GetInt("d9341spawnChance", 20);
            d9341minplys = Qurre.Plugin.Config.GetInt("d9341minplys", 20);
            scp181spawnChance = Qurre.Plugin.Config.GetInt("scp181spawnChance", 20);
            scp181minplys = Qurre.Plugin.Config.GetInt("scp181minplys", 20);
            scp181LuckyNumber = Qurre.Plugin.Config.GetInt("scp181LuckyNumber", 25);
            d9341Description = Qurre.Plugin.Config.GetString("d9341Description", "You are D-9341\nYou can drop a coin to record a postion,then if you are dropped that,you can drop to teleport");
            scp181Description = Qurre.Plugin.Config.GetString("SCP181Description", "You are SCP-181\nYou have a chance to open any door without holding any Keycard");
        }
    }
}
