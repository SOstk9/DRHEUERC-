using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxkampf
{
    internal class Boxer
    {

        private string _name;
        private int _vitalitaet;

        public Boxer(string name, int vitalitaet)
        {
            _name = name;
            _vitalitaet = vitalitaet;
        }

        public void Schlagen()
        {
            Random rnd = new Random();
            int treffer = rnd.Next(0, 2);

            if (treffer == 1)
            {
                _vitalitaet--;
                Console.WriteLine("Treffer!");
            }
            else
            {
                Console.WriteLine("Daneben!");
            }
        }

        public int GetVitalitaet()
        { 
            return _vitalitaet;
        }
        public string GetName()
        {
            return _name;
        }
    }
}
