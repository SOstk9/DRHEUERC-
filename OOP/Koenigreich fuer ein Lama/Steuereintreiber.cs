using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koenigreich_fuer_ein_Lama
{
    public class Steuereintreiber : Einwohner
    {
        double _gesamtSteuern;

        public static List<Einwohner> einwohner = new List<Einwohner>();

        public Steuereintreiber(string name, double einkommen)
        {
            _einkommen = einkommen;
            _name = name;
            _steuerProzent = 10;
            
        }
        public override double ZuVersteuerndesEinkommen()
        {
            return _einkommen;
        }
        
        public double Eintreiben()
        {
            double steuer = 0;

            foreach (Einwohner eini in einwohner)
            {           
                steuer = steuer + eini.Steuer();
            }
            return steuer;
            
        }
    }
}
