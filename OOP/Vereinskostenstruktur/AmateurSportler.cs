using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public class AmateurSportler : AktivesMitglied
    {

        public AmateurSportler(string name, int aktivitaetsgrad)
        {
            _aktivitaetsgrad = aktivitaetsgrad;
            _name = name;
            _einnahmen = 300;
            _ausgaben = _aktivitaetsgrad * 1.5;
        }
        public override void Ausgabe()
        {
            Console.WriteLine(this._name + " " + this._einnahmen + " " + this._ausgaben + " " + this._ueberschuss);
        }
    }
}