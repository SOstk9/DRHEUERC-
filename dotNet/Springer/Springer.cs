using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Springer
{
    internal class Springer
    {
        public int x { get; set; }
        public int y { get; set; }

        private static int counter = 0;

        
        public Springer(int reihe, int spalte)
        {
            x = reihe;
            y = spalte;
        }

        public void Move()
        {

            while (counter != 64)
            {

                counter++;
            }
        }
    }
}
