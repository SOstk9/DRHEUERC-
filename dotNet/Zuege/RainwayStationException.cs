using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zuege
{
    public class RainwayStationException : Exception
    {
        public RainwayStationException(string fehler) : base (fehler)
        {

        }
    }
}