using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> name = new BinaryTree<int>();

            name.Insert(50);
            name.Insert(100);
            name.Insert(10);
            name.Insert(1);
            name.Insert(10);
            name.Insert(75);
            name.Insert(65);
            name.Insert(85);
            name.Insert(61);
            name.Insert(45);
            name.Insert(35);
            name.Insert(15);



            name.PrintInorder();
            Console.ReadLine();
            


        }
    }
}
