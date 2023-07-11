using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInter
{
    public class Canon : IPrinterWindows
    {
        public void ShowPrintDialog()
        {
            Console.WriteLine("canon display printing");
        }

        public void ShowPrintStatus()
        {
            Console.WriteLine("canon printer printing");
        }
    }

}
