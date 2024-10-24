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

            SimpleList<string> liste = new SimpleList<string>(eins);

            Menge<string> menge1 = new Menge<string>();
            menge1.Add(eins);
            menge1.Add(zwei);
            menge1.Add(drei);

            Menge<string> menge2 = new Menge<string>();
            menge2.Add(vier);
            menge2.Add(fuenf);

            Element<string>[] test = new Element<string>[5];
            liste.Add(zwei);
            liste.Add(drei);
            liste.Add(vier);
            liste.Add(fuenf);

            liste.ListeAusgeben();
            test = liste.CreateArrayFromList();
            liste.AnzahlListeAusgeben();
            liste.SearchList("zwei");


            menge1.MengeHinzufügen(menge2);

            Console.ReadLine();

        }
    }
}
