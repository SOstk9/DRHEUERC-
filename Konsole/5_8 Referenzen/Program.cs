using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _5_8_Referenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volumen;
            double mantelflaeche;
            double oberflaeche;
            bool nochmal = true;

            while (nochmal == true)
            {
                Console.WriteLine("Bitte Radius eingeben (in cm)");

                bool istZahl = double.TryParse(Console.ReadLine(), out double radius);
                if ( istZahl == false)
                {
                    Console.WriteLine("Gib ne Zahl ein du Affe!");
                    Thread.Sleep(500);
                    Console.Clear();
                }

                Console.WriteLine("Bitte Höhe eingeben (in cm)");

                bool istZahl2 = double.TryParse(Console.ReadLine(), out double hoehe);
                if (istZahl2 == false)
                {
                    Console.WriteLine("Gib ne Zahl ein du Affe!");
                    Thread.Sleep(500);
                    Console.Clear();
                }

                bool eingabeFalsch = Cone(radius, hoehe, out volumen, out mantelflaeche, out oberflaeche);

                if (eingabeFalsch == false)
                {
                    Console.WriteLine("Eingabe muss positiv sein");
                    Thread.Sleep(500);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Das Volumen ist {0}, die Mantelfläche entspricht {1}, die Oberfläche entspricht {2}", volumen, mantelflaeche, oberflaeche);
                    Console.WriteLine("Möchtest du neue Werte eingeben? (J/N)");
                    string eingabeNochmal = Console.ReadLine();

                    if (eingabeNochmal == "J" || eingabeNochmal == "j")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        nochmal = false;
                    }
                }
            }

            
           

        }
        static bool Cone(double radius, double hoehe, out double volumen, out double mantelflaeche, out double oberflaeche )
        {

            double mantellinie = Math.Pow(radius,2) + Math.Pow(hoehe,2);
            mantellinie = Math.Sqrt(mantellinie);
        

            volumen = (Math.PI * Math.Pow(radius, 2) * hoehe)/3;
            mantelflaeche = Math.PI * mantellinie * radius;
            oberflaeche = Math.PI * radius * (radius + mantellinie);

            if (radius < 0 || hoehe < 0)
            {
                return false ;
            }
            else
            {
                return true;
            }

        }
    }
}
