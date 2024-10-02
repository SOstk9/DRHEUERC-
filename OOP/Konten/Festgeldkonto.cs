using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konten
{
    public class Festgeldkonto : Konto
    {
        private int _laufzeitJahre;
        private DateTime _anlegeDatum;

        public Festgeldkonto(int laufzeitJahre, DateTime anlegeDatum, int kontonr, double kontostand, double zinssatz) : base (kontonr, kontostand, zinssatz=2)
        {
            _laufzeitJahre = laufzeitJahre;
            _anlegeDatum = anlegeDatum;

        }
        public void RestLaufzeit()
        {
            
            int restlaufzeit = (int)DateTime.Today.Subtract(_anlegeDatum).TotalDays;
            int laufzeitTage = (_laufzeitJahre * 365) - restlaufzeit;

            if (laufzeitTage > 365)
            {
                Console.WriteLine($"Die Restlaufzeit beträgt noch {laufzeitTage} Tage.");
            }
            else
            {
                Console.WriteLine($"Die Restlaufzeit beträgt noch {laufzeitTage} Tage.");
            }
        }

        

    }
}