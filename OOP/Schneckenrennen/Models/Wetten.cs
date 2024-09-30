using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schneckenrennen.Models
{
    internal class Wetten
    {
        private string _schneckenName;
        private int _wettEinsatz;
        private string _spieler;
        private Rennen rennen;

        public Wetten(Rennen rennen, string schneckenName, int wettEinsatz, string spieler)
        {
            Rennen race = rennen;
            _schneckenName = schneckenName;
            _wettEinsatz = wettEinsatz;
            _spieler = spieler;

        }
        public string GetName()
            { return _schneckenName; }

        public int GetWettEinsatz()
        {
            return _wettEinsatz;
        }

        public string GetSpieler()
        {
            return _spieler;
        }
    }
}
