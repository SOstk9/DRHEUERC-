using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konten
{
    public class Sparkonto : Konto
    {
        public Sparkonto(int kontonr, int kontostand, double zinsSatz) : base(kontonr, kontostand, zinsSatz = 0.5)
        {
            
        }
    }
}