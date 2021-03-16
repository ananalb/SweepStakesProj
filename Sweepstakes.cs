using System;
using System.Collections;
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

        public void RegisterContestant(Contestant contestant)
        {
            contestant.FirstName = UserInterface.GetUserInputFor("Please enter your First name");
            contestant.LastName = UserInterface.GetUserInputFor("Please enter your Last name");
            contestant.EmailAddress = UserInterface.GetUserInputFor("Please enter your Email");
            contestant.RegistrationNumber = contestants.Count;
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
     

        public Contestant PickWinner()
        {
            Random random = new Random();          
            int randnumber = random.Next(contestants.Count);
            winner = contestants[randnumber];
            foreach(KeyValuePair<int, Contestant> contestant in contestants)
            {
                contestant.Value.Notify(winner);
            }
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
           for(int i = 0; i < contestants.Count; i++)
            {
                Console.WriteLine(contestant.FirstName + "" + contestant.LastName + "" + contestant.EmailAddress + contestant.RegistrationNumber);
            }                   
        }
        
    }
}
