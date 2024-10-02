using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GehaltsrechnerFirma_Vererbung.Models
{
    internal class Angestellter : Mitarbeiter
    {
        private string _tarifgruppe;


        public Angestellter(string tarifgruppe, string name, string vorname, int alter) : base (name, vorname, alter)
        {
            _tarifgruppe = tarifgruppe;

        }

        public void Gehaltsberechnung()
        {
            int gehaltGruppe = 0;
            switch (_tarifgruppe)
            {
                case "A": gehaltGruppe = 2560;
                    break;
                case "B":  gehaltGruppe = 3000;
                    break;
                case "C": gehaltGruppe = 3200;
                    break;
                case "D": gehaltGruppe = 5400;
                    break;

            }

            _gehalt = gehaltGruppe * (1 + ((_alter - 25) / 100));
        }
    }
}
