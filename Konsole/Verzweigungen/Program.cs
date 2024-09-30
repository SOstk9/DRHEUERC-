using System;

namespace Verzweigungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Wert1 = 0;
            int Wert2 = 0;
            int Wert3 = 0;

//Werte eingeben

            Console.WriteLine("Geben Sie 3 Werte ein");
            Wert1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Gespeicher! Nächster Wert");
            Wert2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Gespeicher! Nächster Wert");
            Wert3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Alle Werte gespeichert!");

//Bedingungen

            if (Wert1 > Wert2)
            {
                Console.WriteLine("Wert1 ist größer Wert2");
                if (Wert1 > Wert3)
                {
                    Console.WriteLine("Wert1 ist auch größer als Wert3");
                }
                else
                {
                    Console.WriteLine("Wert ist nicht größer 3");
                }
            }
            else
            {
                if (Wert1 > Wert3)
                {
                    Console.WriteLine("Wert1 ist größer Wert2");
                    if (Wert3 < 5)
                    {
                        Console.WriteLine("Wert1 ist kleiner 5");

                    }
                    else
                    {
                        if (Wert3 < 10)
                        {
                            Console.WriteLine("Wert3 ist kleiner 10");
                        }
                        else
                        {
                            Console.WriteLine("Wert ist ´größer 10");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Keine der Prüfungen ergibt WAHR");
                }

            }
            Console.ReadLine();
        }

    }


}
