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
        public MarketingFirm(ISweepstakesManager choice) 
            //Using dependency injection in the constructor here.
            //Our class is not directly dependent on one object but rather
            //it is dependent on the ISweepstakesManager interface which can connect classes & 
            //which at a later time is "injected" into the class here to be used in conjunction with the factory design.
        {
            _manager = choice;

        }      
        
    }
}
