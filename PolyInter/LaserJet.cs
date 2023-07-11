using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInter
{
    public class LaserJet : IPrinterWindows
    {
        public void ShowPrintDialog()
        {
            Console.WriteLine("LaserJet display printing");
        }

        public void ShowPrintStatus()
        {
            Console.WriteLine("LaserJet printer printing");
        }
    }

}

