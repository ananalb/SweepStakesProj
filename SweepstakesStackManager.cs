using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //uses Stack data as an underlying structure

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            throw new NotImplementedException();
        }
    }
}
