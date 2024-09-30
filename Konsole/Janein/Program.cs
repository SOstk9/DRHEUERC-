using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janein
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool fehler = false;

                Console.WriteLine("Ja oder nein eingeben");
                char eingabe = Console.ReadKey().KeyChar;

                if (eingabe == 'j' || eingabe == 'J')
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben ja eingegeben");
                }

                else if (eingabe == 'n' || eingabe == 'N')
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben nein eingegeben");
                }

                else
                {
                    fehler = true;
                    Console.Clear();
                    Console.WriteLine("Gib J oder N ein!");
                }

            
            Console.ReadLine();
        }
    }
}
