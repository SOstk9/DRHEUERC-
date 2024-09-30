using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabenschelife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int ergebnis = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    if (i %2 == 0 )
            //    {
            //        Console.WriteLine("Gerade Zahl!");
            //    }
            //    else if (i %3 == 0)
            //    {
            //        Console.WriteLine("Kann durch drei geteilt werden!");
            //    }

            //}

            //Console.ReadLine();










            int ergebnis = 0;

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
                double ido = i;
                Console.WriteLine(ido);
                string istr = i.ToString();
                Console.WriteLine(istr);


            }

            Console.ReadLine();









            Console.WriteLine("Bittte Schleifenanzahl eingeben");
            int anzahl = int.Parse(Console.ReadLine());
                for (int i = 1; i <= anzahl ; i++)
            {
                Console.WriteLine(i);
            }

                Console.ReadLine();
        }
    }
}
