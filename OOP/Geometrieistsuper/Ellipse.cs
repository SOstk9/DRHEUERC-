using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometrieistsuper
{
    public class Ellipse : Figur
    {
        private int _radius;
        public int _radius2;

        public Ellipse(int radius, int radius2)
        {
            _radius = radius;
            _radius2 = radius2;
        }

        public override double Flaeche()
        {
            _flaeche = Math.PI * _radius * _radius2;
            return _flaeche;
        }
        public override double Umfang()
        {
            _umfang = Math.PI * Math.Sqrt(2 * (Math.Pow(_radius, 2) + Math.Pow(_radius2, 2)));
            return _umfang;
        }

    }
}