using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] array = new int[10];
            //Random rng = new Random();
            //int max = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rng.Next(100);
            //    Console.WriteLine(array[i]);
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //    }
            //}
            //Console.WriteLine("\nMAX:" + max);
            //Console.ReadLine();





            //int[] array = new int[10];
            //Random rng = new Random();
            //int min = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rng.Next(100);
            //    Console.WriteLine(array[i]);
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (min == 0)
            //    {
            //        min = array[i];
            //    }
            //    else if (array[i] < min)
            //    {


            //        min = array[i];
            //    }
            //}
            //Console.WriteLine(min);
            //Console.ReadLine();




            //Random rng = new Random();

            //int arrayLaenge = 10;
            //int[] array = new int[arrayLaenge];

            //int temp = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rng.Next(100);
            //    Console.WriteLine(array[i]);
            //}


            //for (int j = 0; j < array.Length; j++)
            //{
            //    for (int k = 0; k < array.Length - 1; k++)
            //    {
            //        if (array[k] > array[k + 1])
            //        {
            //            temp = array[k];
            //            array[k] = array[k + 1];
            //            array[k + 1] = temp;
            //        }

            //    }

            //}
            //Console.WriteLine("\n");

            //foreach (int k in array)
            //{
            //    Console.WriteLine(k);
            //}
            //Console.ReadLine();








            Random rng = new Random();
            int arrayLaenge = 100000;
            int[] zahlArray = new int[arrayLaenge];
            int eingabe;
            bool istEingabeZahl = false;
            bool zahlImArray = false;
            int arrayIndex = 0;
            bool cont = true;
            string eingabeString;
            bool exit = true;


            while (exit == true)
            {

                //Array mit Zufallszahlen ausfüllen
                for (int i = 0; i < zahlArray.Length; i++)
            {
                zahlArray[i] = rng.Next(50000);
                //Console.WriteLine(zahlArray[i]);
            }

            
                //Suche nach Zahl
                Console.WriteLine("Welche Zahl willste suchen?");

            istEingabeZahl = int.TryParse(Console.ReadLine(), out eingabe);

           
                if (istEingabeZahl == true)
                {


                    for (int j = 0; j < zahlArray.Length; j++)
                    {
                        if (eingabe == zahlArray[j])
                        {
                            zahlImArray = true;
                            arrayIndex = j;
                            Console.WriteLine("Zahl ist im Array! Sie ist an Stelle {0}, möchtest du weiter suchen? (J/N)", arrayIndex);
                            eingabeString = Console.ReadLine();

                            if (eingabeString == "j")
                            {

                               
                              
                               

                            }
                            else
                            {
                                exit = false;
                                System.Environment.Exit(1);
                            }

                        }
                        else
                        {
                            zahlImArray = false;
                            

                        }
                    }
                    Console.WriteLine("Keine Weitere Zahl mehr vorhanden!");
                    Console.ReadLine();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("gib ne Zahl ein, Brudi!");
                    Thread.Sleep(500);
                    Console.Clear();
                }

            }

            Console.ReadLine();



        }
    }
}
