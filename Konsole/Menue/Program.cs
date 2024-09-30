using System;

namespace Menue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int eingabe;
            int eingabe2;
            bool exit = false;
            bool exit2 = false;


            while (exit == false)
            {
                Console.WriteLine(" Wähle aus: \n1. Erstes Programm\n2. Zweites Programm\n3.Ende");
                eingabe = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (eingabe)
                {
                    case 1:
                        while (exit2 == false)
                        {
                            Console.WriteLine(" Wähle aus: \n1. Erstes Unterrogramm\n2. Zweites Unterprogramm\n3.Zurück");
                            eingabe2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (eingabe2)
                            {
                                case 1:
                                    Console.WriteLine("hallo");
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.WriteLine("hallo2");
                                    Console.Clear();
                                    break;
                                case 3:
                                    exit2 = true;
                                    break;
                                default:
                                    Console.WriteLine("falsche Eingabe!");
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;
                    case 2: continue;
                    case 3:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("falsche Eingabe!");
                        break;
                }
            }






              // Console.ReadLine();
            }
        }
    }
