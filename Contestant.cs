using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
     class Contestant : IContestant
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int RegistrationNumber { get; set; }

        public bool isWinner;
        public void Notify(IContestant contestant)
        {
          if(isWinner == true)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }

        }
    }
}
