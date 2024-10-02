using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konten
{
    public class Girokonto : Konto
    {
        private double _sollZins;
        private string _kategorie;

        public Girokonto(string kategorie, int kontonr, double kontostand, double zinsSatz, double sollZins = 16) : base(kontonr, kontostand, zinsSatz = 0)
        {
            _sollZins = sollZins;
            _kategorie = kategorie;
        }

        public double Dispo()
        {
            if (_kontostand < 0)
            {

                return (Math.Abs(_kontostand) * _sollZins) / 12;
            }
            else
            {
                return 0;
            }
        }

    }
}