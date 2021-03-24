using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager();
            Player player1 = new Player();
            Player player2 = new Player();
            
            player1.Name = "Serkan";
            player1.surName = "Önder";
            player1.TCNo = "12345678910";
            player1.birthDate = "16012000";

            player2.Name = "Argun";
            player2.surName = "Asar";
            player2.TCNo = "1234566789";
            player2.birthDate = "28121999";

            playerManager.Add(player1);
            playerManager.ShowPlayer(player1);
            playerManager.Update(player1);
            playerManager.Campaignz(player1 , new Campaign1());
            playerManager.Delete(player1);

            playerManager.Add(player2);
            playerManager.ShowPlayer(player2);
            playerManager.Update(player2);
            playerManager.Campaignz(player2, new Campaign3());
            playerManager.Delete(player2);



        }
    }
}
