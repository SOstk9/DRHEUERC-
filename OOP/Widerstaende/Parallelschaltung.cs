using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Widerstaende
{
    public class Parallelschaltung : Widerstandsnetz
    {
        public Parallelschaltung(params Widerstand[] widerstand) : base ()
        {
          
            this._name = ErstelleName(widerstand);
        }



        public override double Widerstandsberechnung()
        {
            double zwischenstand = 0;
            foreach (Widerstand widerstand in _widerstandliste)
            {

                
                zwischenstand = zwischenstand + (1 / widerstand.GetWiderstand());
                

            }
            _widerstand = 1 / zwischenstand;
            return _widerstand;
        }
        public string ErstelleName(params Widerstand[] widerstand)
        {
            string _name = "Rp";
            for (int i = 0; i < widerstand.Length; i++)
            {
                _name = _name + " " + widerstand[i].GetName();
            }
            return _name;

        }
    }
}