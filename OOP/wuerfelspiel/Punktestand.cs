using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wuerfelspiel
{
    internal class Player
    {
        private int _score = 0;
        private string _name;

        public Player(string name)
        {
            _name = name;
        }

        public void Gamble()
        {
            Random rnd = new Random();
            for (int i= 0; i < 5; i++)
            {
                
                int wuerfelergebnis = rnd.Next(1, 21);

                _score = _score + wuerfelergebnis;
            }        
        }

        public int GetScore()
        {
            return _score;
        }

        public string GetName()
        {
            return _name;
        }

    }
}
