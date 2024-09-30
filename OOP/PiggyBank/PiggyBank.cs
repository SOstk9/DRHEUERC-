using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    internal class PiggyBank
    {

        private int _einCtZaehler;
        private int _zehnCtZaehler;
        private int _fuenfzigCtZaehler;
        private int _einEuroZaehler;

        private int _geldstueckeVorhanden;
        private int _maxGeldstuecke;
        private bool _aufgebrochen;



        //Konstruktor
        public PiggyBank(int maxAnzahl)
        {
            _maxGeldstuecke = maxAnzahl;
        }

        public int Add1Cents(int centStueckeEingegeben)
        {
            if (centStueckeEingegeben <= _maxGeldstuecke)
            {
                _einCtZaehler = _einCtZaehler + centStueckeEingegeben;
                return 0;
            }
            else
            {
                int ueberlauf = centStueckeEingegeben - _maxGeldstuecke;
                _einCtZaehler = centStueckeEingegeben - ueberlauf;
                return ueberlauf;
            }
        }

        public int Add10Cents(int zehnCentStueckeEingegeben)
        {
            if (zehnCentStueckeEingegeben <= _maxGeldstuecke)
            {
                _zehnCtZaehler = _zehnCtZaehler + zehnCentStueckeEingegeben;
                return 0;
            }
            else
            {
                int ueberlauf = zehnCentStueckeEingegeben - _maxGeldstuecke;
                _zehnCtZaehler = zehnCentStueckeEingegeben - ueberlauf;
                return ueberlauf;
            }
        }

        public int Add50Cents(int fuenfzigCentStueckeEingegeben)
        {
            if (fuenfzigCentStueckeEingegeben <= _maxGeldstuecke)
            {
                _fuenfzigCtZaehler = _fuenfzigCtZaehler + fuenfzigCentStueckeEingegeben;
                return 0;
            }
            else
            {
                int ueberlauf = fuenfzigCentStueckeEingegeben - _maxGeldstuecke;
                _fuenfzigCtZaehler = fuenfzigCentStueckeEingegeben - ueberlauf;
                return ueberlauf;
            }

        }

        public int Add1Euro(int einEuroStueckeEingegeben)
        {
            if (einEuroStueckeEingegeben <= _maxGeldstuecke)
            {
                _einEuroZaehler = _einEuroZaehler + einEuroStueckeEingegeben;
                return 0;
            }
            else
            {
                int ueberlauf = einEuroStueckeEingegeben - _maxGeldstuecke;
                _einEuroZaehler = einEuroStueckeEingegeben - ueberlauf;
                return ueberlauf;
            }
        }

        public void Shake()
        {
            string ausgabeFuellstand = "";
            double einDrittel = _maxGeldstuecke * 0.33;
            double zweiDrittel = _maxGeldstuecke * 0.66;
            double halb = 0.5;
            
            int gesamtZaehler = _einCtZaehler + _zehnCtZaehler + _fuenfzigCtZaehler + _einEuroZaehler;
            
            if(gesamtZaehler == 0)
            {
                ausgabeFuellstand = "leer";
            }
            else if (gesamtZaehler == _maxGeldstuecke)
            {
                ausgabeFuellstand = "voll";
            }
            else if (gesamtZaehler > 0 && gesamtZaehler < ((halb + einDrittel) / 2))
            {
                ausgabeFuellstand = "etwa ein Drittel voll";
            }      
            else if (gesamtZaehler > ((halb + einDrittel) / 2) && gesamtZaehler < ((halb + zweiDrittel) / 2))
            {
                ausgabeFuellstand = "etwa halb voll";
            }
            else if (gesamtZaehler > halb)
            {
                ausgabeFuellstand = "hab voll";
            }
            else if (gesamtZaehler > ((halb + zweiDrittel) / 2) && gesamtZaehler < _maxGeldstuecke)
            {
                ausgabeFuellstand = "etwa zwei Drittel voll";
            }
            Console.WriteLine($"Das Sparschwein ist {ausgabeFuellstand}");
        

        }

        public void IsBroken()
        {
            Console.WriteLine(_aufgebrochen);
        }

        public double BreakInto()
        {
            _aufgebrochen = true;
            double geldBetrag = (_einCtZaehler * 0.01) + (_zehnCtZaehler * 0.1) + (_fuenfzigCtZaehler * 0.5) + (_einEuroZaehler);
            
            _einCtZaehler = 0;
            _zehnCtZaehler = 0;
            _fuenfzigCtZaehler = 0;
            _einEuroZaehler = 0;
            return geldBetrag;
        }



    }
}
