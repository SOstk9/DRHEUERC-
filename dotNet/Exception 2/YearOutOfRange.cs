using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_2
{
    public class YearOutOfRangeException : Exception
    {
        public YearOutOfRangeException(string fehlermeldung) : base (fehlermeldung)
        {
        }
    }
}