using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7_Invert
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //erste Aufgabe

            //int zahl = 0;
            //Invert(ref zahl);
            //Console.WriteLine(zahl);
            //Console.ReadLine();



            //zweite Aufgabe

            //int ersteEingabe = int.Parse(Console.ReadLine());
            //int zweiteEingabe = int.Parse(Console.ReadLine());

            //Swap(ref ersteEingabe, ref zweiteEingabe);

            //Console.WriteLine(ersteEingabe + " " + zweiteEingabe);
            //Console.ReadLine();


            //dritte Aufgabe

            int ersteEingabe = int.Parse(Console.ReadLine());
            int zweiteEingabe = int.Parse(Console.ReadLine());
            int dritteEingabe = int.Parse(Console.ReadLine());

            Sort(ref ersteEingabe, ref zweiteEingabe, ref dritteEingabe);

            Console.WriteLine(ersteEingabe + " " + zweiteEingabe + " " + dritteEingabe);
            Console.ReadLine();


        }

        //erste Aufgabe

        //static void Invert(ref int a)
        //{
        //    if (a == 0)
        //    {
        //        a = 1;
        //    }
        //    else
        //    {
        //        a = 0;
        //    }
        //}

        //zweite Aufgabe

        //static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}


        //dritte Aufgabe

        static void Sort(ref int a,ref int b,ref int c)
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j< 3; j++)
                {
                    if (a > b)
                    {
                        int temp = a;
                        a = b;
                        b = temp;
                    }
                    if (b > c)
                    {
                        int temp = b;
                        b = c;
                        c = temp;
                    }
                }
            }
        }

    }
}
