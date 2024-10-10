using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Vereinskostenstruktur
{
    public class UnterstuetzendesMidglied : Mitglied
    {
        public UnterstuetzendesMidglied(string name)
        {
            _name = name;
            _einnahmen = 100;
            _ausgaben = 15;
        }
        public override void Ausgabe()
        {
            Console.WriteLine(this._name + " " + this._einnahmen + " " + this._ausgaben + " " + this._ueberschuss);
        }
    }
}