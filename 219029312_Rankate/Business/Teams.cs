using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _219029312_Rankate.Business
{
    class Teams
    {
        public string TeamName { get; set; }
        public int NumberOfGoalsScored { get; set; }

        public int generateGoals()
        {
            int num = 0;
            //goals are most likely to be less than 10. so we limit to 9.
            Random rnd = new Random();
            num = rnd.Next(10);
            return num;
        }
    }
}
