using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class Weißwein : Wein
    {

        public Weißwein(string herkunft, string name) : base(herkunft, name)
        {
            Herkunft = herkunft;
            _name = name;
        }
    }
}