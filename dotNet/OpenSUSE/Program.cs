using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSUSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("X:\\ITA5\\Unterlagen\\dotNet\\02 - RegEx\\Froschkönig Unix Zeilenumbrüche.txt");

            string line = sr.ReadToEnd();

            Stack<string> stack = new Stack<string>();

            stack.Push(line);
            Console.WriteLine(line);

            Console.ReadLine();
        }
    }
}
