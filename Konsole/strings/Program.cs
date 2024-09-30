using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char tausch;

            Console.WriteLine("Bitte Wort eingeben:");
            string wort = Console.ReadLine();
            char[] chars = new char [wort.Length];

            for (int i = 0; i < wort.Length; i++)
            {

                chars[i] = wort[i];


            }
           

            

            for ( int i = 0; i < chars.Length -1; i= i+2)
            {

                tausch = chars[i];
                chars[i] = chars[i+1];
                chars[i + 1] = tausch;



            }
            Console.WriteLine(chars);
            Console.ReadLine();
        }
    }
}
