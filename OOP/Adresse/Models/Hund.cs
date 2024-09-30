using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adresse.Models
{
    internal class Hund
    {
        private string _name;
        private bool _istGefuettert;
        private Person person;

        public Hund(string name)
        {
            _name = name;
        }

        public void Fuettern()
        {
            _istGefuettert = true;
            
        }

        public string HundInfo()
        {
            string gefuettert = "";
            if (_istGefuettert == true)
            {
                gefuettert = "Hund ist gefüttert";
            }
            else
            {
                gefuettert = "Hund ist nicht gefüttert";
                

            }
            string info;
            info = "Der Boi heißt " + _name + " " + gefuettert;
            
            return info;

        }

        public bool GassiGehen(Person person)
        {

            if (person.Alter() > 16)
            {
                if (_istGefuettert == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

    }
}
