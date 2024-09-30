using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            double durchschnitt = 0;
            double temp = 0;
            int min = 0;
            int max = 0;

            for (int i = 0; i < array.Length;i++)
            {
               array[i] = random.Next(100);
               Console.WriteLine(array[i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                temp = temp + durchschnitt;
                durchschnitt = (array[i]);

                
            }
            temp = temp + durchschnitt;
            durchschnitt = temp / array.Length;
           // durchschnitt = array.Average();
            Console.WriteLine("AVG: " + durchschnitt);


            for (int i = 0; i < array.Length; i++)
            {
                temp = temp + durchschnitt;
                durchschnitt = (array[i]);


            }
            temp = temp + durchschnitt;


            Console.ReadLine();

        }
    }
}
