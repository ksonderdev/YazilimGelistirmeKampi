using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager : IGameSerivce
    {
        public object PlayerList { get; private set; }

        public void Add(Player player)
        {
            Console.WriteLine("Player has been signed up!");
        }
        public void Delete(Player player)
        {
            Console.WriteLine("Player has been deleted!");
        }
        public void Update(Player player)
        {
            Console.WriteLine("Player updated sucessfully!");

        }
        public void ShowPlayer(Player player)
        {
            Console.WriteLine(player.Name + "  " +  player.surName + "  " + player.TCNo + "  " + player.birthDate);

        }

        internal void Campaignz(Player player, Campaign1 campaign1)
        {
            
        }

        internal void Campaignz(Player player, Campaign2 campaign2)
        {
            
        }

        internal void Campaignz(Player player, Campaign3 campaign3)
        {
            
        }

        public void Campaignz(Player player, Campaigns campaigns)
        {
            campaigns.Campaignsx(player);
        }
        }
    }

