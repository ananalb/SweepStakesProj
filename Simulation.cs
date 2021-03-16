using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Simulation
    {
        


        public Simulation()
        {

        }
        public static ISweepstakesManager ManagerFactory(string choice)
        {
            ISweepstakesManager _manager = null;
            switch (choice)
            {
                case "stack":
                    _manager = new SweepstakesStackManager();
                    break;

                case "queue":
                    _manager = new SweepstakesQueueManager();
                    break;

                default:
                    Console.WriteLine("Please choose a valid Option");
                    ManagerFactory(choice);
                    break;

            }
            return _manager;
        }

        public void CreateMarketingFirm()

        {
            
            Console.WriteLine("Do you want a stack or queue?");
            string userInput = Console.ReadLine();
            ISweepstakesManager chosenManager = ManagerFactory(userInput);
            MarketingFirm marketingFirm = new MarketingFirm(chosenManager);
            marketingFirm.CreateSweepstakes();

        }
    }
}

         

    
   

