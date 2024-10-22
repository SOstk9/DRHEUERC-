using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_2
{
    public class DayOutOfRangeException : Exception
    {
        public DayOutOfRangeException(string fehler) : base(fehler)
        {

        }
    }
}