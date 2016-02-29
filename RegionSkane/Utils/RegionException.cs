using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionSkane.Utils
{
    class RegionException : Exception
    {
        public string errMsg { get; set; }

        public RegionException(int err)
        {
            if (err == 1)
            {
                errMsg = "Databasfel, prova igen. Om det fortfarande inte fungerar vänligen kontakta systemadministratör.";
            }
            else if (err == 2)
            {
                errMsg = "Mappningsfel från databas, prova igen. Om det fortfarande inte fungerar vänligen kontakta systemadministratör.";
            }
            else
            {
                errMsg = "Fel i program, prova igen. Om det fortfarande inte fungerar vänligen kontakta systemadministratör.";
            }
        }
    }
}
