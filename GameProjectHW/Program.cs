using System;

namespace GameProjectHW
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {Id=1,FirstName="Abdulkadir",LastName="Bar",BirthYear=2000,NationlityId=36787155555 });

            Console.WriteLine("*****************************");
            gamerManager.Update(new Gamer { Id = 1, FirstName = "Abdullah Salih", LastName = "Öner", BirthYear = 2000, NationlityId = 11017381518 });

            Console.WriteLine("********************************");

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game 
            { Name = "Battelfield",
              Price = 250,
              DateOfRelease=2015 
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Start(new Campaign 
            {CampaignName="Black Friady",
            SaleRate="%50",
            LastValidity="13.02.2021"
            });



        }
    }
}
