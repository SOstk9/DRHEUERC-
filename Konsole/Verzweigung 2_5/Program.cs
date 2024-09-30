using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verzweigung_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //double zahl = 0;
            //double betrag = 0;


            //Console.WriteLine("Bitte Zahl eingeben:");
            //    zahl = double.Parse(Console.ReadLine());

            //if (zahl < 0)
            //{
            //    betrag = zahl * (-1);
            //}
            //else if (zahl == 0)
            //{
            //    betrag = zahl * 0;
            //}
            //else
            //{
            //    betrag = zahl;
            //}

            //Console.WriteLine("der Betrag der Zahl {0} ist {1}.", zahl, betrag);
            //Console.ReadLine();

            Console.WriteLine("Auswahl:");
            char menu = Console.ReadKey().KeyChar;
            //int auswahl = int.Parse(menu.ToString());

            switch (menu)
            {
                case '1':
                    Console.WriteLine("test");
                    break;
                case '2':
                    Console.WriteLine("test2");
                    break;
                default:
                    Console.WriteLine("falsche Eingabe");
                    break;
            }
            Console.ReadLine();

        }
    }
}





//-------------------------------------


