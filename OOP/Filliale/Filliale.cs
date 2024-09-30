using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filliale
{
    internal class Filliale
    {
       
            private string _name;
            private int _warenbestand;
            private double _kasse;
        

        public Filliale(string name, int warenbestand, double kasse)
        {
            _name = name;
            _warenbestand = warenbestand;
            _kasse = kasse;
        }

        public void Information()
        {
            Console.WriteLine($"Filiale:{_name}, Warenbestand: {_warenbestand}, _kasse {_kasse}");

        }

        public void Einkauf()
        {
            if (_warenbestand <= 10)
            {
                _kasse = _kasse - 10;
                _warenbestand++;
            }
            else
            {
                Console.WriteLine("Kein Geld mehr du Affe!");
            }
        }

        public void Verkauf()
        {
            if (_warenbestand > 0)
            {
                _kasse = _kasse + 10;
                _warenbestand--;
            }
            else
            {
                Console.WriteLine("Keine Waren mehr du Arschloch!");
            }
        }
    }
}

