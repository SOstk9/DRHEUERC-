using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatoren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 0;
            int zahl2 = 0;
            char operat;
            int ergebnis = 0;
            bool fehler = false;

            Console.WriteLine("Bitte Zahl 1 eingeben");
            zahl1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte Zahl 2 eingeben");
            zahl2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte Operator eingeben");
            operat = Console.ReadKey().KeyChar;

            switch (operat)
            {
                case '+':
                    ergebnis = zahl1 + zahl2;
                    break;
                case '-':
                    ergebnis = zahl1 - zahl2;
                    break;
                case '*':
                     ergebnis = zahl1 * zahl2;
                    break;
                case '/':
                       ergebnis = zahl1 / zahl2;
                    break;
                default:
                    fehler = true;
                    Console.Clear();
                    Console.WriteLine("----------\njunge, das ist kein Operant!");
                    break;
            }
            if (fehler == false)
            {
                Console.Clear();
                Console.WriteLine("----------\nDas Ergebnis ist {0}", ergebnis);
             
            }
            Console.ReadLine();



        }
    }
}
