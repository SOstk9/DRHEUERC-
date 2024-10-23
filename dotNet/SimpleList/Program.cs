using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Element<string> eins = new Element<string>("name");
            Element<string> zwei = new Element<string>("zwei");
            Element<string> drei = new Element<string>("drei");
            Element<string> vier = new Element<string>("vier");
            Element<string> fuenf = new Element<string>("fünf");

            SimpleList<Element<string>> liste = new SimpleList<Element<string>>();

            liste.Add(eins);


        }
    }
}
