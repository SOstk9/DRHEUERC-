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
        private string _nameWettbuero;
        private Rennen _rennen;
        private List<Wetten> _angenommeneWetten = new List<Wetten>();
        private int _faktor;
        private Wetten _wette;

        public Wettbuero(Rennen rennen, int faktor, string nameWettbuero)
        {
            _rennen = rennen;
            _faktor = faktor;
            _nameWettbuero = nameWettbuero;
        }

        public void WetteAnnehmen(Rennen rennen, string schneckenName, int wettEinsatz, string spieler)
        {
            Wetten wette = new Wetten(rennen, schneckenName, wettEinsatz, spieler);
            _angenommeneWetten.Add(wette);
        }

        public bool WetteGewonnen(int eintrag)
        {   bool wetteGewonnen = false;

            int betrag = 0;
            if (_angenommeneWetten[eintrag].GetName() == _rennen.ErmittleGewinner())
            {
                Console.WriteLine("Wette gewonnen!");
                wetteGewonnen = true; 
                return wetteGewonnen; ;
            }
            else
            {
                Console.WriteLine("Wette verloren (Sportwetten können süchtig machen)");
                return wetteGewonnen; ;
            }
        }



        public void RennAblauf()
        {
            _rennen.Durchfuehren();
        }

        //public void WetteErgebnis()
        //{
        //    if 
        //}
        public string Ausgabe()
        {

            string ausgabe = "Wettbüro: " + _nameWettbuero + _rennen.Ausgabe() + "Wettquote: " + _faktor + "\n\nTeilnehmende Schneckos: " + _rennen.AusgabeSchneckenNamen();
            return ausgabe;
        }
    }
}
