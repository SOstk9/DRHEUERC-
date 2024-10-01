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
        private int _wettEinsatz;

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

        public string WetteGewonnen(int eintrag)
        {  

         
            if (_angenommeneWetten[eintrag].GetName() == _rennen.ErmittleGewinner())
            {
                double wettErgebnis = WetteErgebnis();
                return "Wette gewonnen! Du bekommst: " + wettErgebnis; 

            }
            else
            {
                return "Wette verloren. Glücksspiel kann süchtig machen."; ;
            }
        }



        public void RennAblauf()
        {
            _rennen.Durchfuehren();
        }

        public double WetteErgebnis()
        {
            double wettergebnis = 0 ;
            for (int i = 0; i < _angenommeneWetten.Count; i++)
            {
                wettergebnis = _angenommeneWetten[i].GetWettEinsatz() * _faktor;
                
            }
            return wettergebnis;

        }
        public string Ausgabe()
        {

            string ausgabe = "Wettbüro: " + _nameWettbuero + _rennen.Ausgabe() + "Wettquote: " + _faktor + "\n\nTeilnehmende Schneckos: " + _rennen.AusgabeSchneckenNamen();
            return ausgabe;
        }
    }
}
