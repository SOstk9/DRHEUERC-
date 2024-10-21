using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("uwe", "feref", 2);

            p.Name = "Fred";
        }
    }
}
