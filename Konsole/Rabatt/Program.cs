using System;

namespace Rabatt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stueckzahl     = 0;
            double einzelpreis = 0;
            double gesamtpreis = 0;
            double rabatt      = 1;
            bool fehler        = true;

            Console.WriteLine("Stückzahl eingeben");
            stueckzahl = int.Parse(Console.ReadLine());

            Console.WriteLine("Einzelpreis eingeben");
            einzelpreis = int.Parse(Console.ReadLine());


//fehler abchecken

            if (einzelpreis < 0 || stueckzahl < 0)
            {
                Console.WriteLine("Fehler!");
                fehler = true;

            }
//vergleichen der Menge der eingegebenen Stückzahl

            if (fehler = false && stueckzahl < 10 && stueckzahl >= 0)

            {
                rabatt = 1;

            }
            else if (stueckzahl >= 10 && stueckzahl <= 50)
            {
                rabatt = 0.95;

            }
            else if (stueckzahl > 50)
            {
                rabatt = 0.9;
            }
         

            if (fehler = false)

            {
                gesamtpreis = stueckzahl * einzelpreis * rabatt;
                Console.WriteLine("Der Gesamtpreis ist {0}", gesamtpreis);
            }

            Console.ReadLine();
        }
    }
}
