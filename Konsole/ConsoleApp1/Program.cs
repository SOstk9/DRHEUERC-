using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        struct Person
        {
            public int Id;
            public string Vorname;
            public string Nachname;
            private string Password;
        }
        static void Main(string[] args)
        {

            List<Person> person = new List<Person>();
            double mal = Multiplizieren(1, 2, 3, 4, 56);
            Console.WriteLine(mal);
            Console.ReadLine();

        }
        static double Multiplizieren(params double[] zahl1  )
        {
            double ergebnis = 1;

            foreach(double zahl in zahl1)
            {
                ergebnis = ergebnis * zahl;
            }
            return ergebnis;

        }
    }
}
