using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace HalloWelt
{
    internal class Program
    {




        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Namen eingeben: \n---------------------");
            string user = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hallo {0} ", user);
            Console.WriteLine("{0}, bitte Zahl 1 eingeben: \n---------------------", user);
            
                string eingabeZahl = Console.ReadLine();
                int zahl = int.Parse(eingabeZahl);

            Console.WriteLine("{0}, bitte Zahl 2 eingeben: \n---------------------", user);
            
                string eingabeZahl2 = Console.ReadLine();
                int zahl2 = int.Parse(eingabeZahl2);
            
            int ergebnisAddition = zahl + zahl2;
            int ergebnisSubtraktion = zahl - zahl2;
            int ergebnisMultiplikation = zahl * zahl2;
            int ergebnisDivision = zahl / zahl2;

            Console.WriteLine("Das Ergebnis der Addition ist {0}", ergebnisAddition);
            Console.WriteLine("Das Ergebnis der Subtraktion ist {0}", ergebnisSubtraktion);
            Console.WriteLine("Das Ergebnis der Multiplikation  ist {0}", ergebnisMultiplikation);
            Console.WriteLine("Das Ergebnis der Division ist {0}", ergebnisDivision);
            Console.ReadLine();
        }
    }
}
