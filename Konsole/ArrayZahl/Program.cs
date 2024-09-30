using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayZahl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int arrayLaenge = 5000;
            int[] zufall = new int[arrayLaenge];
            int[] nummerierung = new int[10];
            int laengeZufall = zufall.Length;
            int laengeNummerierung = nummerierung.Length;

            for (int i = 0; i < laengeZufall; i++)
            {
                zufall[i] = rng.Next(10);
            }

            for (int i = 0; i < laengeNummerierung; i++)
            {
                for (int j = 0; j < laengeZufall; j++)
                {
                    if (i == zufall[j])
                    {
                        nummerierung[i] = nummerierung[i] + 1;
                    }
                }
            }
            for (int i = 0; i < laengeNummerierung; i++)
            { 
            Console.WriteLine("Häufigkeit von {0} ist {1}", i+1, nummerierung[i]);
            
            }
            Console.ReadLine();

        }
    }
}
