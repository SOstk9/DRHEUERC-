using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bier bier = new Bier("Hafferöder", "KultBier");
            Wein wein = new Wein("Schwabenland", "Jauchs Bester");
            Weißwein weiß = new Weißwein("Frankfurt", "Weißwein");

            Flasche <Getränk> rund = new Flasche<Getränk>(bier);

            Console.WriteLine(rund.IstLeer());
            Console.ReadLine();

            rund.Leeren();
            Console.WriteLine(rund.IstLeer());
            Console.ReadLine();

            Flasche<Getränk> braun = new Flasche<Getränk>(wein);

            Console.WriteLine(braun.IstLeer());
            Console.ReadLine();

            braun.Leeren();
            Console.WriteLine(braun.IstLeer());

            braun.Füllen(weiß);
            Console.WriteLine(braun.IstLeer());
            Console.ReadLine();

            

   
            

            
            
        }
    }
}
