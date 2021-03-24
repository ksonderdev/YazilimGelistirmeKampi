using System;
using System.Collections.Generic;
using System.Text;

namespace HWGame
{
    class GameManager : IGameService
    {
        public void Add(Player player)
        {
            if(IPlayerValidService(player) == true)
            {
                Console.WriteLine("You've successfully sign up!");
            }
            else
            {
                Console.WriteLine("Sign up failed!");
            }
        }

        private bool IPlayerValidService(Player player)
        {
           
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Player deleted sucessfully");
        }

        public void Update(Player Player)
        {
            Console.WriteLine("Profile updated sucessfully!");
        }
    }
}
