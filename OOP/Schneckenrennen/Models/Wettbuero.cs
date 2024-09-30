using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Schneckenrennen.Models
{
    internal class Wettbuero
    {
        private Rennen _rennen;
        private List<Wetten> _angenommeneWetten;
        private int _faktor;
        private Wetten _wette;

        public Wettbuero(Rennen rennen, int faktor)
        {
            _rennen = rennen;
            _faktor = faktor;
        }

        public void WetteAnnehmen(Rennen rennen, string schneckenName, int wettEinsatz, string spieler)
        {
            Wetten wette = new Wetten(rennen, schneckenName, wettEinsatz, spieler);
            _angenommeneWetten.Add(wette);
        }

        public void RennAblauf()
        {
            _rennen.Durchfuehren();
        }

        public string Ausgabe()
        {
            string ausgabe = "";
            return ausgabe;
        }
    }
}
