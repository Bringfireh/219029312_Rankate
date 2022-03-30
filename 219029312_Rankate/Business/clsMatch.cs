using System;
using System.Collections.Generic;
using System.IO;
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

        //Write Results to File.C:\Users\Ngutor\source\repos\219029312_Rankate\219029312_Rankate\Data\EPL.txt
        public void writeToFile()
        {
            string basedir = AppDomain.CurrentDomain.BaseDirectory;
            string[] realpath = basedir.Split(new string[]{"bin","Debug"}, StringSplitOptions.None);
            string apppath = realpath[0];
            
            //string filepath = apppath + "Data\\EPL.txt";
           
            string path = Path.Combine(apppath + "Data", "EPL.txt");
            using (StreamWriter file = new StreamWriter(path, append: true)){
                file.WriteLine($"{home.TeamName} vs {away.TeamName}");
                file.WriteLine($"     {home.NumberOfGoalsScored}        {away.NumberOfGoalsScored}");
                file.WriteLine(".........................................");
            }
        }
    }
}
