using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koenigreich_fuer_ein_Lama
{
    public abstract class Einwohner
    {
        protected double _einkommen;
        protected double _steuerProzent;
        protected string _name;

        


        public void SetzeEinkommen(double einkommen)
        {
            _einkommen = einkommen;
        }

        public abstract double ZuVersteuerndesEinkommen();
        public virtual string GetName()
        {
            return _name;
        }


        public double Steuer()
        {
            double versteuerndesEinkommen = ZuVersteuerndesEinkommen();
            double steuer = versteuerndesEinkommen * (_steuerProzent/100);

            if (this is Koenig)
            {
                steuer = 0;
                return steuer;
            }
            if (steuer <= 1 && this is not Leibeigener)
            {
                steuer = 1;
                return steuer;
            }

            if (this is Adel)
            {

                if (steuer <= 20)
                {
                    steuer = 20;
                }
                return steuer;

            }

            
            return steuer;
           
    }

    }
}