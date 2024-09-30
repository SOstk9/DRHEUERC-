using System;
using System.Linq;
using System.Reflection;

namespace Strukturen
{
    internal class Program
    {
        struct Datum
        {
            public int tag;
            public int monat;
            public int jahr;

        }
        static void Main(string[] args)
        {
            Datum[] heutigerTag = new Datum[365];


            int counter = 0; 

            for (int j = 1; j < 13 ; j++)
            {


                for (int k = 1; k < 32; k++)
                {

                    if (counter == 365)
                    {
                        break;
                    }

                    if (j == 2 && k > 28)
                    {
                        break;
                    }
                    if (k > 30)
                    {
                        if (j == 4 || j == 6 || j == 9|| j == 11)
                        {
                            break;
                        }
                    }
                    heutigerTag[counter].tag = k;
                    heutigerTag[counter].monat = j;
                    heutigerTag[counter].jahr = 2014;
                    counter++;
                  
                    
                }

            }
            Console.ReadLine();
            

            foreach (Datum datum in heutigerTag)
            {
                Console.WriteLine("Tag: {0}, Monat: {1}, Jahr{2}", datum.tag, datum.monat, datum.jahr);
                //Console.WriteLine(datum.monat);
                //Console.WriteLine(datum.jahr);
            }
            Console.ReadLine();






        }
    }
}
