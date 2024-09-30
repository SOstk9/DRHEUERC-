using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teststrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = string.Format("{0:D}", 10092024);
            Console.WriteLine(s);
            Console.ReadLine();
            string[] array = { "eins", "zwei", "drei" };
            string joined = string.Join(",", array);
            Console.WriteLine(joined);
            Console.ReadLine();
            string sInsert = joined.Insert(5, "Peter");
            Console.WriteLine(sInsert);
            Console.ReadLine();
            string sd = "Stairway Heaven";
            sd = sd.Insert(9, "to ");
Console.WriteLine(sd);
            Console.ReadLine();

            int date = 7;
            int xa = date >= 8 ? 1 : 0;

        }
    }
}
