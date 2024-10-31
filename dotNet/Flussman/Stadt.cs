using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flussman
{
    public class Stadt
    {
        private string _name;

        public Stadt(string name)
        {
            _name = name;
        }


        public void ReagiereWasserschutzwand(object fluss, WasserStandEventArgs e)
        {
            if(e._neuerWasserStand > 8200)
            {
                Console.WriteLine($"{_name} Hochfahren! Die Wasserschutzwand!");
            }
            else
            {
                Console.WriteLine($"{_name} nichts");
            }
        }
    }
}