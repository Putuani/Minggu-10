﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInter
{
    public class Epson : IPrinterWindows
    {
        public void ShowPrintDialog()
        {
            Console.WriteLine("Epson display printing");
        }

        public void ShowPrintStatus()
        {
            Console.WriteLine("Epson printer printing");
        }
    }
    
}
