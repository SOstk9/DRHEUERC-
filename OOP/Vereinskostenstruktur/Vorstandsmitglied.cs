using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public class Vorstandsmitglied : Mitglied
    {
        private int _kompetenz;

        public Vorstandsmitglied(string name, int kompetenz)
        {
            _name = name;
            _kompetenz = kompetenz;
            _einnahmen = _kompetenz * 100;
            _ausgaben = _einnahmen * 20;
        }
        public override void Ausgabe()
        {
            Console.WriteLine(this._name + " " + this._einnahmen + " " + this._ausgaben + " " + this._ueberschuss);
        }
    }
}