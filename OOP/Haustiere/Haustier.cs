using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haustiere
{
    public abstract class Haustier
    {
        protected string _name;
        protected bool _steuerpflichtig;
        protected double _jahreskostenTierarzt;


        public Haustier(string name, bool steuerpflichtig, double jahreskostenTierarzt)
        {
            _name = name;
            _steuerpflichtig = steuerpflichtig;
            _jahreskostenTierarzt = jahreskostenTierarzt;
        }
        public string GetName()
        {
            return _name;
        }

        public bool GetSteuerpflicht()
        {
            return _steuerpflichtig;
        }

        public double GetKosten()
        {
            return _jahreskostenTierarzt;
        }

        public abstract string Beschreibung();
    }
}