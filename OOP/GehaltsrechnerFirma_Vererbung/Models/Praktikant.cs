using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GehaltsrechnerFirma_Vererbung.Models
{
    internal class Praktikant : Mitarbeiter
    {
        private string _abteilung;

        public Praktikant(string abteilung, string name, string vorname, int alter) : base(name, vorname, alter)
        {
            _abteilung = abteilung;
        }

        public void Gehaltsberechnung()
        {
            

            switch (_abteilung)
            {
                case "Entwicklung": _gehalt = 935;
                    break;
                case "Produktion": _gehalt = 710;
                    break;
                case "Vertrieb": _gehalt = 820;
                    break;
                 
            }

        }
    }
}
