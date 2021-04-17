using Qurre.API.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ExtraRoles
{
    public class EventHandler
    {
        public static System.Random rand = new System.Random();
        public Plugin plugin;
        public EventHandler(Plugin plugin) => this.plugin = plugin;
        public static Dictionary<bool, Vector3> d9341pos = new Dictionary<bool, Vector3>();
        public void OnRoundStart()
        {
            RolesSpcript.D_9341.SelectdSpawn9341();
        }
        public void OnDrop(DropItemEvent ev)
        {
            if (ev.Player == RolesSpcript.D_9341.d9341 && d9341pos.ContainsKey(false))
            {
                d9341pos.Add(true, ev.Player.Position);
            }
            else if (ev.Player == RolesSpcript.D_9341.d9341 && d9341pos.ContainsKey(true))
            {
                ev.Player.Position = d9341pos[true];
                d9341pos.Add(false, ev.Player.Position);
            }
        }
        public void OnDead(DeadEvent ev)
        {
            if (ev.Target == RolesSpcript.D_9341.d9341)
            {
                RolesSpcript.D_9341.Killd9341();
            }
            else if (ev.Target == RolesSpcript.SCP_181.scp181)
            {
                RolesSpcript.SCP_181.KillScp181();
            }
        }
        public void OnInteract(InteractDoorEvent ev)
        {
            int number =  rand.Next(1, 100);
            if (ev.Player == RolesSpcript.SCP_181.scp181 && ev.Door.Permissions.RequiredPermissions.Equals("") == false)
            {
               if (ev.Player.ItemInHand == ItemType.None && number <= Configs.scp181LuckyNumber)
                {
                    ev.Allowed = true;
                    ev.Player.ShowHint("\n\n\n\n<pos=50>success</pos");
                }
               else if (ev.Player.ItemInHand == ItemType.None && number > Configs.scp181LuckyNumber)
                {
                    ev.Allowed = false;
                    ev.Player.ShowHint("\n\n\n\n<pos=50>miss</pos");
                }
            }
        }
    }
}
