using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class Bier : Getränk
    {
        public string Brauerei
        { get; set; }


        public Bier (string Brauerei, string name) : base(name)
        {
            _name = name;
        }
        public void BrauereiAusgabe()
        {
            Console.WriteLine(Brauerei);
        }

    }
}