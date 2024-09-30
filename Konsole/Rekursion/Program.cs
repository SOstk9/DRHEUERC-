using System;

namespace Rekursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int n = 5;
            int potenz = Potenz(a, n);
            Console.WriteLine(potenz);
            Console.ReadLine();


            Console.WriteLine("Bitte Dividend eingeben:");
            int ersteZahl = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte Divisor eingeben");
            int dividend = int.Parse(Console.ReadLine());
            int gemeinsamerTeiler = GemeinsamerTeiler(ersteZahl, dividend);
            Console.WriteLine(" Der größte gemeinsamer Teiler ist {0}", gemeinsamerTeiler);
            Console.ReadLine();



        }
        #region Potenz
        static int Potenz(int a, int n)
        {
            if (n > 1)
            {
                return a * Potenz(a, n - 1);
            }
            else
            {
                return a;
            }


        }
        #endregion
        #region GemeinsamerTeiler
        static int GemeinsamerTeiler(int ersteZahl, int dividend)
        {
            if (dividend > 0)
            {
                int rest;
                rest = ersteZahl % dividend;
                ersteZahl = dividend;
                dividend = rest;

                return GemeinsamerTeiler(ersteZahl, dividend);
            }
            else
            {
                return ersteZahl;
            }
        }
        #endregion
        #region GemeinsamerTeiler2
        static int GemeinsamerTeiler2(int ersteZahl, int dividend)
        {
            if (dividend > 0)
            {
                return GemeinsamerTeiler(dividend, ersteZahl % dividend);
            }
            else
            {
                return ersteZahl;
            }
        }
        #endregion
    }
}
