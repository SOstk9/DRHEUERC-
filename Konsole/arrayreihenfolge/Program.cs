using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayreihenfolge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] zufallsZahlen1 = new int[20];
            int[] zufallsZahlen2 = new int[20];
            int[] zufallsZahlen3 = new int[20];
            int[] zufallsZahlen4 = new int[20];
            int[] zufallsZahlen5 = new int[20];

            int counter = 1;

            int[,] tabelle = new int[5, 5 ];

            //Zufallszahlen füllen

            for (int i = 0; i < 20; i++)
            {
                zufallsZahlen1[i] = rnd.Next(1, 11);
                zufallsZahlen2[i] = rnd.Next(1, 11);
                zufallsZahlen3[i] = rnd.Next(1, 11);
                zufallsZahlen4[i] = rnd.Next(1, 11);
                zufallsZahlen5[i] = rnd.Next(1, 11);
            }

            //dsfjdsf

           
            for (int i = 1; i < zufallsZahlen1.Length; i++)
            {
                if (zufallsZahlen1[i] == zufallsZahlen1[i - 1] + 1)

                {
                    counter = counter +1;
              
                } 
                else if (counter != 1)
                {
                    tabelle[0, counter]= tabelle[0, counter]+1;
                    counter = 1;
                }
                
            }

            for (int i = 0; i < tabelle.GetLength(1); i++)
            {
                Console.WriteLine("Aufeinanderfolgende Zahlen: {0} Anzahl:{1}", i, tabelle[0,i]);

            }
            
         
            Console.ReadLine();

        }
    }
}
