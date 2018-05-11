using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemWatcher.Library.Helpers
{
    public static class UnitConverter
    {
        public static double BytesToGigaBytes(long bytes)
        {
            double gb = 0;
            gb = ((double)bytes / 1024);
            gb = gb / 1024;
            gb = gb / 1024;
            return Math.Round(gb,2);
        }
        public static double BitsPerSecondToMegaBitsPerSecond(long bitsPerSecond)
        {
            double Mbps = 0;
            Mbps = ((double)bitsPerSecond / 1024);
            Mbps = Mbps / 1024;            
            return Math.Round(Mbps, 2);
        }           
    }
}
