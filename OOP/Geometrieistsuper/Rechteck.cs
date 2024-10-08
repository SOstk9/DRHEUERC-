using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometrieistsuper
{
    public class Rechteck : Figur
    {
        private int _laenge;
        private int _breite;
        
        public Rechteck(int laenge, int breite)
        {
            _laenge = laenge;
            _breite = breite;
        }

        public override double Flaeche()
        {
            _flaeche = _laenge * _breite;
            return _flaeche;
        }

        public override double Umfang()
        {
            _umfang = 2 * _laenge + 2* _breite;
            return _umfang;
        }
    }
}