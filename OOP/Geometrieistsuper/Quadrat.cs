using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometrieistsuper
{
    public class Quadrat : Figur
    {
        private int _laenge;

        public Quadrat(int laenge)
        {
            _laenge = laenge;
        }

        public override double Flaeche()
        {
            _flaeche = _laenge * _laenge;
            return _flaeche;
        }

        public override double Umfang()
        {
            _umfang = _laenge * 4;
            return _umfang;
        }
    }
}