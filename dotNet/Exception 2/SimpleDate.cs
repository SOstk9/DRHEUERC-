using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_2
{
    public class SimpleDate
    {
        private int _year;
        private int _month;
        private int _day;

        public int Year
        {
            get { return _year; }
            set
            {
                try
                {
                    if (value < 9999 && value > 0)
                    {
                        _year = value;
                    }
                    else
                    {
                        throw new Exception("YearOutOfException");
                    }
                }
                catch
                {
                    Console.WriteLine("Außerhalb der JahresRange");
                }
            }
                
                
        }

        public int Month
        {
            get { return _month; }
            set { _month = value;}

        }

        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }
    }
}