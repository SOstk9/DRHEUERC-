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
            //Elemente erstellen

            Element<string> eins = new Element<string>("name");
            Element<string> zwei = new Element<string>("zwei");
            Element<string> drei = new Element<string>("drei");
            Element<string> vier = new Element<string>("vier");
            Element<string> fuenf = new Element<string>("fünf");

            //Liste erstellen
            SimpleList<string> liste = new SimpleList<string>(eins);


            //der Liste Menge1 Elemente hinzufügen
            Menge<string> menge1 = new Menge<string>();
            menge1.Add(eins);
            menge1.Add(zwei);
            menge1.Add(drei);

            //der Liste menge2 Elemente hinzufügen
            Menge<string> menge2 = new Menge<string>();
            menge2.Add(vier);
            menge2.Add(fuenf);

            //der Liste test Elemente hinzufügen
            Element<string>[] test = new Element<string>[5];
            liste.Add(zwei);
            liste.Add(drei);
            liste.Add(vier);
            liste.Add(fuenf);

            //Ausführungen

            liste.ListeAusgeben();

            Console.WriteLine("--------------------------------------");

            //Array wird aus der Liste erstellt und anschließend die Anzahl der vorhandenen Elemente in der Liste ausgegeben
            test = liste.CreateArrayFromList();

            liste.AnzahlListeAusgeben();

            Console.WriteLine("--------------------------------------");

            //Das Element wird in der Liste gesucht und es wird ausgegeben, ob es in der Liste vorhanden ist
            liste.SearchList("zwei");
            liste.SearchList("zwölf");

            Console.WriteLine("--------------------------------------");

            Console.ReadLine();

        }
    }
}
