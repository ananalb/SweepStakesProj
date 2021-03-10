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
        private ISweepstakesManager _manager;


        public Simulation()
        {

        }
        public ISweepstakesManager CreateMarketingFirmWithManager(string choice)
        {

            switch (choice)
            {
                case "1":
                    _manager = new SweepstakesStackManager();
                    break;

                case "2":
                    _manager = new SweepstakesQueueManager();
                    break;

                default:
                    Console.WriteLine("Please choose a valid Option");
                    CreateMarketingFirmWithManager(choice);
                    break;

            }
            return _manager;
        }

        public void CreateMarketingFirm()

        {
            ISweepstakesManager chosenManager = CreateMarketingFirmWithManager("1");
            MarketingFirm marketingFirm = new MarketingFirm(chosenManager);

        }
    }
}

         

    
   

