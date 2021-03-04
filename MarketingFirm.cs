using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;
        public MarketingFirm()
        {

        }
    
        public void DoMarketingFirm(ISweepstakesManager manager)
        {
            UserInterface.GetUserInputFor("SweepstakesStackManager or SweepstakesQueueManager?");
            ISweepstakesManager sw= null;
            switch (manager)
            {
                case SweepstakesStackManager():
                    _manager = new SweepstakesStackManager();
                    break;
                case "2":
                    _manager = new SweepstakesQueueManager();
                    break;
                default:
                    Console.WriteLine("Not valid");
                    DoMarketingFirm(manager);
                    break;
            }
            return sw;

        }


        public void CreateSweepStake()
        {
            DoMarketingFirm(_manager);
            
        }

    }
}
