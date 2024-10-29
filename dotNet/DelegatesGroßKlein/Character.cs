using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void CharacterHandler(string eingabe);

namespace DelegatesGroßKlein
{
    internal class Character
    {

        public static void UpperCase(string theorie)
        {
            Console.WriteLine(theorie.ToUpper());
            
        }

        public static void LowerCase(string ent)
        {
            Console.WriteLine(ent.ToLower());
            
        }

        public static void UpperLower(string tanga)
        {
            Console.WriteLine(tanga.ToUpper());

            Console.WriteLine(tanga.ToLower());
           
        }



    }
}
