using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konten
{
    public class Person
    {
        private string _name;
        private string _vorname;
        private List<Konto> _konto = new List<Konto>();
        public Person(string name, string vornamen, Konto konto)
        {
            _name = name;
            _vorname = vornamen;
            _konto.Add(konto);
        }
        public void AddKonto(Konto konto)
        {
            _konto.Add(konto);
        }
    }
}