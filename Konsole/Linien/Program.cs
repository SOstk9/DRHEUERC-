using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Linien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startx = 0;
            int starty = 0;
            int endx = 10;
            int endy = 10;
           Linie(startx,starty, endx, endy);
          

            Console.ReadLine();
        }

        static void Linie(int startx, int starty, int endx, int endy)
        {

            Console.SetCursorPosition(startx, starty);
            Console.Write("*");
            Console.SetCursorPosition(endx, endy);
            Console.Write("*");

            int midx = (startx + endx) / 2;
            int midy = (starty + endy) / 2;
            Console.SetCursorPosition(midy, midy);
            Console.Write("*");
            endx = midx;
            endy = midy;

            if (endx > 0)
            {
                Linie(startx, starty, endx, endy);
            }

          
        }
    }
}
