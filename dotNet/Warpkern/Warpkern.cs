using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warpkern
{
    public delegate void TemperaturEventHandler(object Warpkern, WarpkernEventArgs e);
    internal class Warpkern
    {
        public double _warpKernTemperatur;
        public string _name;

        public event TemperaturEventHandler TemperaturAenderung;

        public double WarpkernTemperatur
        {
            get { return _warpKernTemperatur; }
            set
            {
                               
                    TemperaturAenderung?.Invoke(this, new WarpkernEventArgs(_warpKernTemperatur, value));
                    _warpKernTemperatur = value;
                
            }
        }

        public Warpkern(string name, double  warpKernTemperatur)
        {
            _name = name;
            _warpKernTemperatur = warpKernTemperatur;
        }

        public override string ToString()
        {
            return _name;
        }

    }
}
