using System;
using System.Diagnostics;
using System.Security.Policy;
using System.Threading;

namespace namewert
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //bool falscheEingabe = false;

            //do
            //{
            //    Console.WriteLine("Bitte Paar eingeben:");
            //    //bool wortBool = ;
            //    string wort = Console.ReadLine();
            //    if (wort.Contains("="))
            //    {
            //        Console.WriteLine("Länge:{0}", wort.Length - 1);
            //        string[] teile = wort.Split('=');
            //        Console.WriteLine("Name: {0}", teile[0]);
            //        Console.WriteLine("Name: {0}", teile[1]);
            //        falscheEingabe = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Gleichzeichen angeben!");
            //        Thread.Sleep(300);
            //        Console.Clear();
            //        falscheEingabe = true;
            //    }

            //}
            //while (falscheEingabe == true);
            //Console.ReadLine();








            Console.WriteLine("Bitte Wort eingeben:");
            string eingabe = Console.ReadLine();
            string eingabetrim = eingabe.Trim();
                eingabetrim = eingabe.Replace(" ", "");
            char[] rueckwaerts = eingabe.ToCharArray();
            eingabetrim = eingabetrim.ToLower();


            Array.Reverse(rueckwaerts);

            string rueckwaertsergebnis = new string(rueckwaerts);
            rueckwaertsergebnis = rueckwaertsergebnis.Replace(" ", "");
            rueckwaertsergebnis = rueckwaertsergebnis.ToLower();





            if (eingabetrim == rueckwaertsergebnis)
            {
                Console.WriteLine(eingabetrim);
                Console.WriteLine("Ist ein Palindrom");
            }
            else
            {
                Console.WriteLine("Kein Palindrom!");
            }
            Console.WriteLine(eingabetrim);
            Console.ReadLine();








            //int eingabe;
            //bool eingabeTest = false;
            //string konvertiert = "";
            //int binaer;
            //int counter = 0;


            //while (eingabeTest == false)
            //{
            //    Console.WriteLine("Geben Sie eine Ganzzahl ein:");
            //    eingabeTest = int.TryParse(Console.ReadLine(), out binaer);
            //    if (eingabeTest == true)
            //    {
            //        for (int i = 0; i < binaer;)
            //        {
                        
            //            if (binaer % 2 == 0)
            //            {
            //                konvertiert = konvertiert.Insert(0, "0");
            //            }
            //            else
            //            {
            //                konvertiert = konvertiert.Insert(0, "1");
            //            }
                       
            //            counter++;
            //            if (counter % 4 == 0)
            //            {
            //                konvertiert = konvertiert.Insert(0, " ");
            //                konvertiert = konvertiert.Insert(0, "0");
                            
            //            }
            //            binaer = binaer / 2;

            //        }

            //        Console.WriteLine(konvertiert);

            //    }
            //    else
            //    {
            //        Console.WriteLine("Das ist keine Ganzzahl!");
            //        Thread.Sleep(300);
            //        Console.Clear();
            //    }
            //}
            //Console.ReadLine();





        }
    }
}
