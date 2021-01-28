using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine("İndirim eklendi"); 
        }

        public void Delete(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine("İndirim silindi");
        }

        public void Update(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine("İndirim güncellendi");
        }
    }
}
