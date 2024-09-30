using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zumtesten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SetCursorPosition method
            Console.WriteLine("Line1");
            Console.WriteLine("Line2");
            Console.WriteLine("Line3 to erase");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("        ");
            Console.ReadLine();
        }
    }
}
