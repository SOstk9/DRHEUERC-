using System;

namespace Exception_2
{
    public class SimpleDate
    {
        private int _year;
        private int _month;
        private int _day;
        private bool _schaltjahr;

        public int Year
        {
            get { return _year; }
            set
            {
               
                    if (value <= 9999 && value > 0)
                    {
                        _year = value;
                    }
                    else
                    {
                        throw new YearOutOfRangeException("Glaub ich dir nicht");
                    }
                

            }


        }

        public int Month
        {
            get { return _month; }
            set
            {
                try
                {
                    if (value > 0 && value < 13)
                    {
                        _month = value;
                    }
                    else
                    {
                        throw new MonthOutOfRangeException("1-12 für die Monate eingeben!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }

        public int Day
        {
            get { return _day; }
            set
            {
                //Schaltjahr prüfen
                if (_year < 1583)
                    if (_year % 4 == 0)
                    {
                        _schaltjahr = true;
                    }
                    else
                    {
                        _schaltjahr = false;
                    }
                else
                {
                    if (_year % 4 == 0)
                    {
                        if (_year % 100 == 0)
                        {
                            if (_year % 400 == 0)
                            {
                                _schaltjahr = true;
                            }
                        }
                        else
                        {
                            _schaltjahr = true;
                        }

                    }
                    else
                    {
                        _schaltjahr = false;
                    }
                }


                //exception

                    if (_schaltjahr == true)
                    {
                        if (_month == 2)
                        {
                            if (value > 0 && value < 30)
                            {
                                _day = value;
                            }
                            else
                            {
                                throw new DayOutOfRangeException("Schaltjahr! 1-29 eingeben!");
                            }

                        }

                    }
                    else
                    {
                        if (_month == 2)
                        {
                            if (value > 0 && value < 29)
                            {
                                _day = value;
                            }
                            else
                            {
                                throw new DayOutOfRangeException("1-28 eingeben!");
                            }
                        }
                        else if (_month == 4 || _month == 6 || Month == 9 || Month == 11)
                        {
                            if (value > 0 && value < 31)
                            {
                                _day = value;
                            }
                            else
                            {
                                throw new DayOutOfRangeException("1-30 eingeben");
                            }
                        }
                        else
                        {
                            if (value > 0 && value < 32)
                            {
                                _day = value;
                            }
                            else
                            {
                                throw new DayOutOfRangeException("1-31 eingeben");
                            }
                        }
                    }
                }




           
        }
    }
}