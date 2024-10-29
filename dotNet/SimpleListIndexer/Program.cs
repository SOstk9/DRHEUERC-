using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleListIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleList simpleList = new SimpleList();

            Element element = new Element("Peter");
            Element element2 = new Element("Horst");
            Element element3 = new Element("Rudolf");

            simpleList.Add(element);
            simpleList.Add(element2);
            simpleList.Add(element3);

            simpleList.Print();
            Console.ReadLine();
        }
    }
}
