using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warpkern
{
    internal class WarpKernKonsole
    {
        public string _name;

        public WarpKernKonsole(string name)
        {
             _name = name;
        }

        public void ReagiereAufTemperatur(object warpkern, WarpkernEventArgs e)
        {
            if (e._newTemperature > 500)
            {
                Console.WriteLine($"Temperatur von {warpkern} ist über 500 Grad, ich schraube herunter");
                e._newTemperature = 200;

            }   

                Console.WriteLine($"Die alte Temperatur beträgt {e._oldTemperature}, die neue {e._newTemperature}");

        }
    }
}
