using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koenigreich_fuer_ein_Lama
{
    public class Leibeigener : Einwohner
    {
        public Leibeigener(string name, double einkommen)
        {
            _einkommen = einkommen;
            _name = name;
            _steuerProzent = 20;
        }

        
        public override double ZuVersteuerndesEinkommen()
        {
            if (_einkommen <= 12)
            {
                return 0;
            }
            else
            {
                return _einkommen;
            }
        }
    }
}