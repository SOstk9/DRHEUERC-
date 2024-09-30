using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schneckenrennen.Models
{
    internal class Rennschnecke
    {
        private string _name;
        private int _maxGeschwindigkeit;
        private int _wegZurueckgelegt;
        private Rennen rennen;

        public Rennschnecke(string name, int maxGeschwindigkeit)
        {
            _name = name;
            _maxGeschwindigkeit = maxGeschwindigkeit;
        }

        public void Krieche()
        {
            Random random = new Random();
            int temp = random.Next(0, _maxGeschwindigkeit);
            _wegZurueckgelegt = _wegZurueckgelegt + temp;
        }

        public string Ausgabe()
        {
            string ausgabe = _name + _maxGeschwindigkeit + _wegZurueckgelegt;
            return ausgabe;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetMaxGeschwindigkeit()
        {
            return _maxGeschwindigkeit;
        }

        public int WegZurueckgelegt()
        {
            return _wegZurueckgelegt;
        }

        public void SetName(string name)
        {
            _name =name;
        }

        public void SetMaxGeschwindigkeit(int maxGeschwindigkeit)
        {
            _maxGeschwindigkeit = maxGeschwindigkeit;
        }

        private void SetWegZurueckgelegt(int wegzurueckgelegt)
        {
            _wegZurueckgelegt = wegzurueckgelegt;
        }
    }
}
