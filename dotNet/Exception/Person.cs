using System;
using System.CodeDom;

namespace Exception
{
    public class Person
    {
        private string _name;
        private string _vorname;
        private int _alter;


        public string Name
        {
            get { return _name; }
            set { _name = value;}
        }

        public string Vorname
        {
            get { return _vorname;}
            set { _vorname = value;}
        }

        public int Alter
        {
            get { return _alter;}
            set
            {
                try
                {
                    if (value >= 0)
                    {
                        _alter = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException ("FalschesAlter");
                    }

                }
                catch
                {
                    Console.WriteLine("Alter kliener 0!");
                }
            }
        }


    }


}