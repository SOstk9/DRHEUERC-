﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_2
{
    public class MonthOutOfRangeException : Exception
    {
        public MonthOutOfRangeException(string fehler) : base(fehler)
        {

        }
    }
}