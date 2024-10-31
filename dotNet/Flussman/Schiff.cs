using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flussman
{
    public class Schiff
    {
        private string _name;


        public Schiff(string name)
        {
            _name = name;
        }
        public override string ToString()
        {
            return _name;
        }

        public void ReagiereAnhalten(object schiff, WasserStandEventArgs e)
        {
            if(e._neuerWasserStand < 250 || e._neuerWasserStand > 8000)
            {
                Console.WriteLine($"Halt Stopp {schiff}!");
            }
            else
            {
                Console.WriteLine("Fahr");
            }
           
        }

      
    }
}