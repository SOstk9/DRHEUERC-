using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Geometrieistsuper
{
    public class Kreis : Figur
    {
        private int _radius;

        public Kreis (int radius)
        {
            _radius = radius;
        }
        public override double Flaeche()
        {
            _flaeche = Math.Pow(_radius,2) * Math.PI;
            return _flaeche;
        }
        public override double Umfang()
        {
            _umfang = 2 * Math.PI * _radius;
            return _umfang;
        }
    }
}