using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adresse.Models
{
    internal class Adresse
    {
        private string _straße;
        private string _hausnr;
        private string _plz;
        private string _ort;


        public Adresse(string straße, string hausnummer, string plz, string ort)
        {
            _straße = straße;
            _hausnr = hausnummer;
            _plz = plz;
            _ort = ort;
        }

        public void AusgabeAdresse()
        {
            Console.WriteLine(this._straße);
            Console.WriteLine(this._hausnr);
            Console.WriteLine(this._plz);
            Console.WriteLine(this._ort);
            
        }
    }
}
