using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konten
{
    public class Konto
    {
        protected int _kontonr;
        protected double _kontostand;
        protected double _habenzinssatz;
        

        public Konto(int kontonr, double kontostand, double zinsSatz)
        {
            
        }

        public void Einzahlen(int betrag)
        {
            _kontostand = _kontostand + betrag;
        }

        public void Auszahlen(int betrag)
        {

            _kontostand = _kontostand - betrag;
        }

        public double Zinsen()
        {
            return _habenzinssatz;
        }

        public double Kontostand()
        {
            return _kontostand;
        }
    }
}