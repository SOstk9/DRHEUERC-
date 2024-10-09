using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koenigreich_fuer_ein_Lama
{
    public class Adel : Einwohner
    {
        public Adel(string name, double einkommen)
        {
            _einkommen = einkommen;
            _name = name;
            _steuerProzent = 20;
        }
        public override double ZuVersteuerndesEinkommen()
        {
            return _einkommen;
        }
    }
}