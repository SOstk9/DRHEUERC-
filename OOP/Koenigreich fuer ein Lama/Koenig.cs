using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koenigreich_fuer_ein_Lama
{
    public class Koenig : Einwohner
    {
        public Koenig(string name, double einkommen)
        {
            _einkommen = einkommen;
            _name = name;
            _steuerProzent = 0;
        }

       
        public override double ZuVersteuerndesEinkommen()
        {
            return 0;
        }
       
    }
}