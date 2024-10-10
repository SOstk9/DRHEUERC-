using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public class Verein : Mitglied
    {
        private int _maxMitglieder;
        private int _anzahlMitglieder;
        public List<Mitglied> mitglieder = new List<Mitglied>();

        public Verein(string name, int maxMitglieder)
        {
            _name = name;
            _maxMitglieder = maxMitglieder;
        }
        public void MitgliedHinzufuegen(Mitglied mitglied)
        {
            

            if (_anzahlMitglieder >= _maxMitglieder)
            {
                Console.WriteLine("Maximale Anzahl Mitglieder erreicht!");
            }
            else
            {

                mitglieder.Add(mitglied);
                _anzahlMitglieder++;
            }
        }

        public double GesamtEinnahmenBerechnen()
        {
            foreach (Mitglied m in mitglieder)
            {
                _einnahmen = _einnahmen + m.GetEinnahmen();
            }

            return _einnahmen;

        }

        public double GesamtAusgabenBerechnen()
        {
            foreach (Mitglied m in mitglieder)
            {
                _ausgaben = _ausgaben + m.GetAusgaben();
            }

            return _ausgaben;

        }

        public double UeberschussBerechnen()
        {
            foreach (Mitglied m in mitglieder)
            {
                _ueberschuss = _ueberschuss + m.GetUeberschuss();
            }

            return _ueberschuss;
        }

        public override void Ausgabe()
        {
            foreach (Mitglied m in mitglieder)
            {
                Console.WriteLine(m.GetName() + " " + m.GetEinnahmen() + " " + m.GetAusgaben() + " " + m.GetUeberschuss());
            }
        }
    }
}