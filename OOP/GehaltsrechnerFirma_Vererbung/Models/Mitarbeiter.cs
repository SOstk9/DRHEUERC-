using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GehaltsrechnerFirma_Vererbung.Models
{
    internal class Mitarbeiter
    {
        protected string _name;
        protected string _vorname;
        protected int _alter;
        protected int _gehalt;



        public Mitarbeiter(string name, string vorname, int alter)
        {
            _name = name;
            _vorname = vorname;
            _alter = alter;
            
        }

        public int GetGehalt()
        { return _gehalt; }
    }
}
