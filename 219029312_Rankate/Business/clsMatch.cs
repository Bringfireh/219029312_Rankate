using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _219029312_Rankate.Business
{
    class clsMatch
    {
        private Teams home = new Teams();
        private Teams away = new Teams();

        //Play the Match.
        public void playMatch()
        {
            Console.WriteLine("Please type the name of the first Team");
            home.TeamName = Console.ReadLine();
            home.NumberOfGoalsScored = home.generateGoals();
            Console.WriteLine("Please type the name of Second Team");
            away.TeamName = Console.ReadLine();
            away.NumberOfGoalsScored = away.generateGoals();
        }

        //Display Match Results
        public void displayResult()
        {
            if (home.NumberOfGoalsScored ==away.NumberOfGoalsScored)
            {
                Console.WriteLine($"{home.TeamName} draw with {away.TeamName}");
            }
            else
            {
                Console.WriteLine($"{home.TeamName} : {home.NumberOfGoalsScored} - {away.NumberOfGoalsScored}: {away.TeamName}");
            }
        }

        //Write Results to File.
        public void writeToFile()
        {

        }
    }
}
