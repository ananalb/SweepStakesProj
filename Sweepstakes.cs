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

        public void RegisterContestant(Contestant contestant)
        {
            contestant.FirstName = UserInterface.GetUserInputFor("Please enter your First name");
            contestant.LastName = UserInterface.GetUserInputFor("Please enter your Last name");
            contestant.EmailAddress = UserInterface.GetUserInputFor("Please enter your Email");
            ContestantRegistrationNumber();
        }

        public double ContestantRegistrationNumber()
        {
            double count = 0;
            for(int i = 0; i < contestants.Count; i++)
            {
                count++;
            }
            return count;
        }

        public Contestant PickWinner()
        {
            Random random = new Random();
            winner = new Contestant();          
            random.Next(contestants.Count);
            return winner;
        }

        public void PrintContestantInfo()
        { 
            foreach (Contestant contestant in contestants)
            {
                Console.WriteLine(contestant.FirstName + "" + contestant.LastName + "" + contestant.RegistrationNumber);

            }
        }
    }
}
