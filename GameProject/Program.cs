using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            { 
                Id = 1, 
                BirthYear = 1984, 
                FirstName = "ENGİN", 
                LastName = "DEMİROĞ", 
                IdentityNumber = 12345
            });

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.BirthYear = 1996;
            gamer1.FirstName = "ENES";
            gamer1.LastName = "TURAN";
            gamer1.IdentityNumber = 12345;

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "CS GO";
            game1.UnitPrice = 50;

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Yaz İndirimi";
            campaign1.CampaignPercent = 50;

            Console.WriteLine("Sevgili " + gamer1.FirstName + " " + game1.GameName + " oyununda % " + campaign1.CampaignPercent + " indirim başladı" );

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(game1,campaign1,gamer1);

            GameManager game = new GameManager();
            game.Add(game1);

        }
    }
}
