using System;

namespace HWGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            NewUserValidationService newUserValidationService = new NewUserValidationService();
            Player player1 = new Player();
            gameManager.Add(new Player
            {
                birthDate = "16012000",
                TCNo = "12345678910",
                Name = "Serkan",
                surName = "Önder",
            });


        }
    }
}
