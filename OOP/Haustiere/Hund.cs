using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haustiere
{
    public class Hund : Haustier
    {
        private string _rasse;

        public Hund (string rasse, string name, double jahreskosten) : base(name, true, jahreskosten)
        {
            _rasse = rasse;

        }
        public string GetRasse()
        {
            return _rasse;
        }

        public override string Beschreibung()
        {
            string steuerpflicht;
            if (_steuerpflichtig)
            {
                steuerpflicht = "steuerpflichtig";
            }
            else
            {
                steuerpflicht = "nicht steuerpflichtig";
            }
            string beschreibung = "Der Hund " + _name + "ist " + steuerpflicht;
            return beschreibung;
        }
    }
}