using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Widerstaende
{
    public class Widerstand
    {
        protected double _widerstand;
        protected string _name;

        protected Widerstand ()
        {

        }
        public Widerstand(string name, double widerstand)
        {
            _widerstand = widerstand;
            _name = name;
        }
        public double GetWiderstand()
        {
            return _widerstand;
        }

        public string GetName()
        {
            return _name;
        }

        public void Ausgabe()
        {
            Console.WriteLine($"Der Widerstand {_name} ist {_widerstand} Ohm groß.");
        }
    }
}