using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace Haustiere
{
    public class Katze : Haustier
    {
        private Vogel _lieblingsVogel;

        public Katze (Vogel vogel, string name, double jahreskosten) : base (name,false,jahreskosten)
        {
            _lieblingsVogel = vogel;
        }
        public string Vogel()
        {
            string vogel = _lieblingsVogel.GetName();
            return vogel;
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
            string beschreibung = "Die Katze " + _name + "ist " + steuerpflicht;
            return beschreibung;
        }

        public void SetLieblingsVogel(Vogel vogel)
        {
            _lieblingsVogel = vogel;
        }
    }
}