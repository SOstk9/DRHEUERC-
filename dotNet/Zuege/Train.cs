using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zuege
{
    public class Train
    {
        private int _zugnummer;
        private int _anzahlWaggons;

        public int Zugnummer
        {
            get { return _zugnummer; }
            set { _zugnummer = value; }
        }
        public int AnzahlWaggons
        {
            get => _anzahlWaggons;
            set { _anzahlWaggons = value; }
        }
                
    }
}