using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahnarztpraxis.Models
{
    internal class Krankenkasse
    {
        private int _id;
        private string _name;

        public Krankenkasse(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public string AusgabeKrankenkasse()
        {
            string getter = _id.ToString() + " " + _name;
            return getter;
        }
        
    }
}
