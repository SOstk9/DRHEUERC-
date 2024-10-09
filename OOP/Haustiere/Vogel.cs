using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haustiere
{
    public class Vogel : Haustier
    {
        private bool _singvogel;


        public Vogel (bool singvogel, string name, double jahreskosten) : base(name, false, jahreskosten)
        {
            _singvogel = singvogel;
        }

        public bool GetSingvogel()
        {
            return _singvogel;
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
            string beschreibung = "Der Vogel " + _name + "ist " + steuerpflicht;
            return beschreibung;
        }

    }
}