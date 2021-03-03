using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public Contestant winner;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
        }

        //public void RegisterContestant(Contestant contestant)
        //{
        //    contestant.FirstName = UserInterface.GetUserInputFor("Please enter your first name");
        //    contestant.LastName = UserInterface.GetUserInputFor("Please enter your last name");
        //    contestant.EmailAddress = UserInterface.GetUserInputFor("Please enter your email address");
            
        //}

        public Contestant PickWinner()
        {
            winner = new Contestant();
            
        }
    }
}
