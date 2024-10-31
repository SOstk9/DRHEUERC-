using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flussman
{
    public delegate void WasserStandEventHandler(object sender, WasserStandEventArgs e);
    public class Fluss
    {
        private string _name { get; set; }
        private int _wasserstand;


        public int Wasserstand
        {
            get { return _wasserstand; }
            set
            {
                if (value > 100 && value < 10000)
                {
                    WasserstandGeaendert?.Invoke(this, new WasserStandEventArgs(_wasserstand, value));
                }
                else
                {
                    Console.WriteLine("falsche Eingabe");
                }
            }
        }
       EventArgs
        public event WasserStandEventHandler WasserstandGeaendert;

        public Fluss(string name, int wasserstand)
        {
            _name = name;
            Wasserstand = wasserstand;
        }

        public override string ToString()
        {
            return _name;
        }


    }
}