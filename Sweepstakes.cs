﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes : IContestant
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
            contestant.RegistrationNumber = ContestantRegistrationNumber();
        }

        public int ContestantRegistrationNumber()
        {
            int count = 0;
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
            random.Next(15);
            return winner;
        }

        public void Notify(Contestant contestant)
        {
            PickWinner();
            Console.Write($"Congratulations.You won! {contestant.FirstName} + {contestant.LastName}");
        }

        public void PrintContestantInfo(Contestant contestant)
        {
           for(int i = 0; i < contestants.Count; i++)
            {
                Console.WriteLine(contestant.FirstName + "" + contestant.LastName + "" + contestant.EmailAddress + contestant.RegistrationNumber);
            }                   
        }
        public void Notify(IContestant winner)
        {
            foreach (IContestant contestant in contestants)
                
                contestant.Notify(winner);
            }
        }
    }
}
