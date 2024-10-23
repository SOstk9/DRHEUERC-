using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class Wein : Getränk
    {
        protected string Herkunft
        { get; set; }

        public Wein (string herkunft, string name) : base(name)
        {
            Herkunft = herkunft;
        }
        public void WeinAusgabe()
        {
            Console.WriteLine(Herkunft);
        }
    }
}