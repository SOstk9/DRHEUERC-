using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap_nachbauen_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int i = 1;


            do
            {
                Console.WriteLine("{0}", i);
                if (i == 39)
                {
                    i = 61;
                }
                else
                {
                    i = i + 1;
                }
            }
            while (i <= 100);

            Console.ReadLine();





            //------------------------




            for (i = 0; i <= 100;)
            {

                Console.WriteLine(i);
                if (i == 39)
                {
                    i = 61;
                }
                else
                {
                    i = i + 1;
                }
            }


            //-----------------------




            while (i <= 100)
            {
                Console.WriteLine(i);
                if (i == 39)
                {
                    i = 61;
                }
                else
                {
                    i = i + 1;
                }
            }

        }
    }
}
