using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometrieistsuper
{
    public abstract class Figur
    {
        protected double _flaeche;
        protected double _umfang;

        //public Figur(double flaeche, double umfang)
        //{
        //    _flaeche = flaeche;
        //    _umfang = umfang;
        //}
       public abstract double Flaeche();

       public abstract double Umfang();
       
    }
}