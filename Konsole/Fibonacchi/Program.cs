using System;
using System.Threading;

namespace Fibonacchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool falscheEingabe = true;
            bool neueZahl1 = true;
            while (falscheEingabe == true)
            {
                while (neueZahl1 == true)
                {
                    Console.WriteLine("Bitte Anzahl Schleifen eingeben:");
                    int anzahl;
                    bool istZahl = int.TryParse(Console.ReadLine(), out anzahl);
                    Console.WriteLine("\n");
                    if (istZahl)
                    {

                        int aktuelleNummer = 1;
                        int letzteNummer = 0;

                        Console.WriteLine(letzteNummer);
                        Console.WriteLine(aktuelleNummer);


                        for (int i = 2; i < anzahl; i++)
                        {
                            int fibonacci = aktuelleNummer + letzteNummer;
                            Console.WriteLine(fibonacci);
                            letzteNummer = aktuelleNummer;
                            aktuelleNummer = fibonacci;

                        }

                        bool ad = false;
                        while (ad == false)
                        {
                            Console.WriteLine("Möchten sie eine neue Zahl eingeben? (0 oder 1)");

                            int neueZahl;
                            bool neueZahlParse = int.TryParse(Console.ReadLine(), out neueZahl);

                            if (neueZahlParse == true)
                            {
                                if (neueZahl == 1)
                                {
                                    neueZahl1 = true;
                                    ad = true;
                                    Console.Clear();
                                }
                                else
                                {
                                    System.Environment.Exit(1);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Du Affe!");
                                Thread.Sleep(300);
                                Console.Clear();
                                ad = false;

                            }
                        }
                    }

                    else
                    {

                        Console.WriteLine("Bitte Zahl eingeben!");
                        Thread.Sleep(300);
                        Console.Clear();

                    }
                }
            }

            Console.ReadLine();
        }
    }
}
