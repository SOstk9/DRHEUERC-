using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public class Trainer : AktivesMitglied
    {
        public Trainer(string name, int aktivitaetsgrad)
        {
            _aktivitaetsgrad = aktivitaetsgrad;
            _name = name;
            _einnahmen = 120;
            _ausgaben = _aktivitaetsgrad * 50;
        }
        public override void Ausgabe()
        {
            Console.WriteLine(this._name + " " + this._einnahmen + " " + this._ausgaben + " " + this._ueberschuss);
        }
    }
}