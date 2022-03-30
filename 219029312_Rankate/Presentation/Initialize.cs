using _219029312_Rankate.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _219029312_Rankate.Presentation
{
    class Initialize
    {
        public void Execute()
        {
            Teams tm = new Teams();
            clsMatch cm = new clsMatch();

            cm.playMatch();

            cm.displayResult();

            cm.writeToFile();
        }
    }
}
