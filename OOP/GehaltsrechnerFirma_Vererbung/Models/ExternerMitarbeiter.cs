using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GehaltsrechnerFirma_Vererbung.Models
{
    internal class ExternerMitarbeiter : Mitarbeiter
    {
        private int _projektStunden;
        
        public ExternerMitarbeiter(int projektStunden, string name, string vorname, int alter) : base(name, vorname, alter)
        {
            _projektStunden = projektStunden;
        }

        public void Gehaltsberechnung()
        {
            _gehalt = _projektStunden * 75;
        }
    }
}
