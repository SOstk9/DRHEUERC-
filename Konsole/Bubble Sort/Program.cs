using System;
using System.Threading;

namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] zufall = new int[10];
            //int temp = 0;
            //Random rng = new Random();


            //for (int i = 0; i < zufall.Length; i++)
            //{
            //    zufall[i] = rng.Next(1, 10);
            //}


            //for (int i = 0; i < zufall.Length; i++)
            //{
            //    for (int j = 0; j < zufall.Length - 1; j++)
            //    {
            //        if (zufall[j] > zufall[j + 1])
            //        {
            //            temp = zufall[j + 1];
            //            zufall[j + 1] = zufall[j];
            //            zufall[j] = temp;
            //        }


            //    }
            //}
            //foreach (int i in zufall)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();




            Random rnd = new Random();

            //Zufallszahl generieren und Duplikate ausblenden

            int[] zufall = new int[20];
            bool exists = false;
            int temp = 0;


            ArrayMitZufallBefuellen(zufall);
            ArraySortieren(zufall);
           int indexStelle = TeileUndHerrsche(zufall);
            Console.WriteLine("Index:{0}", indexStelle);
            Console.ReadLine();

                //if (exists == true)
                //{
                //    exists = false;
                //}
                //temp = rnd.Next(1, 11);
       
                //for (int j = 0; j < zufall.Length; j++)
                //{
                //    if (temp == zufall[j])
                //    {
                //        exists = true;
                //        break;
                //    }

                //}
                //if (exists == false)
                //{
                //    zufall[i] = temp;
                //    i++;
                //}
           





            //Zahlen sortieren



            //Eingabe
            bool zahlVorhanden = false;
            int eingabeZahl = 0;
            string eingabe;
            int average = 0;

            //Prüfun, ob eingegebene Zahl im Array ist

            while (zahlVorhanden == false)
            {
                Console.WriteLine("Bitte eingeben");

                eingabe = Console.ReadLine();
                bool istEingabezahl = int.TryParse(eingabe, out eingabeZahl);

                if (istEingabezahl == true)
                {


                    average = zufall.Length / 2;

                    for (int i = 0; i < zufall.Length; i++)
                    {
                        if (eingabeZahl == zufall[i])
                        {

                            zahlVorhanden = true;
                            break;
                        }


                    }
                    if (zahlVorhanden == false)
                    {
                        Console.WriteLine("Zahl nicht vorhanden, neue Zahl eingeben");
                        Thread.Sleep(500);
                        Console.Clear();
                    }
                

                }
                else
                {

                    Console.WriteLine("Falsche Eingabe, du Affe!");
                }
            }



            //Teile und herrsche

            int schleifencounter = 1;
                for (int i = 0; i < zufall.Length; i++)
                {
                    while (eingabeZahl != zufall[average])
                    {
                        if (eingabeZahl == zufall[average])
                        {
                            schleifencounter++;
                            Console.WriteLine("Die gesuchte Zahl befindet sich an Stelle {0}. Die Anzahl an Durchläufen beträgt {1}", average, schleifencounter);
                            break;
                        }
                        if (eingabeZahl < zufall[average])
                        {
                            average = average / 2;
                            schleifencounter++;
                        }
                        else
                        {
                            average = (average + zufall.Length) / 2;
                            schleifencounter++;
                        }

                    }

                }
                Console.WriteLine("Die gesuchte Zahl befindet sich an Stelle {0}. Die Anzahl an Durchläufen beträgt {1}", average, schleifencounter);
           


            Console.ReadLine();


        }

        static int[] ArrayMitZufallBefuellen(int[] anzahl)
        {
            Random rnd = new Random();

            for (int i = 0; i < anzahl.Length;i++)
            {
                anzahl[i] = rnd.Next(1, 20);
            }

            return anzahl;
        }


        static int[] ArraySortieren(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {

                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;

                    }
                }
            }
            return array;
        }

        static int TeileUndHerrsche(int[] zufall)
        {
            Console.WriteLine("Bitte eingeben:");
            string mama = Console.ReadLine();
            int eingabeZahl = int.Parse(mama);
            bool zahlVorhanden = false;
            if (zahlVorhanden == false)
            {
                Console.WriteLine("Zahl nicht vorhanden, neue Zahl eingeben");
                Thread.Sleep(500);
                Console.Clear();
            }
            int schleifencounter = 1;
            int average = zufall.Length / 2;
            for (int i = 0; i < zufall.Length; i++)
            {
                while (eingabeZahl != zufall[average])
                {
                    if (eingabeZahl == zufall[average])
                    {
                        schleifencounter++;
                        Console.WriteLine("Die gesuchte Zahl befindet sich an Stelle {0}. Die Anzahl an Durchläufen beträgt {1}", average, schleifencounter);
                        break;
                    }
                    if (eingabeZahl < zufall[average])
                    {
                        average = average / 2;
                        schleifencounter++;
                    }
                    else
                    {
                        average = (average + zufall.Length) / 2;
                        schleifencounter++;
                    }

                }
                Console.WriteLine("Die gesuchte Zahl befindet sich an Stelle {0}. Die Anzahl an Durchläufen beträgt {1}", average, schleifencounter);

                

            }
            return average;
        }
   
    }
}
