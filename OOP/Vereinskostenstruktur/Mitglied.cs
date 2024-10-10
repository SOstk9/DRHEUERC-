using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public abstract class Mitglied
    {
        protected double _einnahmen;
        protected double _ausgaben;
        protected double _ueberschuss;
        protected string _name;

        public double GetEinnahmen()
        {
            return _einnahmen;
        }

        public double GetAusgaben()
        {
            return _ausgaben;
        }

        public double GetUeberschuss()
        {
            double ueberschuss = _einnahmen - _ausgaben;
            return ueberschuss;
        }

        public string GetName()
        {
            return _name;
        }

        public abstract void Ausgabe();
    }
}