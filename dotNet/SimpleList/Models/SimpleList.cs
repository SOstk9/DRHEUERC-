using System;

namespace SimpleList
{
    public class SimpleList<T> where T : IComparable
    {
        Element<T> first;
        Element<T> last;
        Element<T> element;


        public SimpleList(Element<T> name)
        {
            first = name;
            last = name;
        }

        public void Add(Element<T> item)
        {
            last.Next = item;
            last = item;

        }



        public void DeleteList()
        {
            Element<T> neu = first;
            while (neu != null)
            {

                neu = null;
                neu = neu.Next;
                
            }
          

        }

        public bool SearchList(T suchText)
        {
            Element<T> neu = first;
            while(neu != null)
            {
                if (neu.First.CompareTo(suchText) == 0)
                {
                    Console.WriteLine("Ist in der Liste vorhanden!");
                    return true;
                }
                neu = neu.Next;
            }
            return false;
            
        }

        public void ListeAusgeben()
        {
            Element<T> erster = first;
            
            while(erster != null)
            {
                Console.WriteLine(erster.First);
                erster = erster.Next;
                
            }

        }

        public Element<T>[] CreateArrayFromList()
        {
            int counter = 0;

            Element<T> zaehler = first;
            while (zaehler != null)
            {
                counter++;
                zaehler = zaehler.Next;
            }

            Element<T>[] array = new Element<T>[counter];
            zaehler = first;
            
                for (int i = 0; i < counter; i++)
                {
                    array[i] = zaehler;
                    zaehler = zaehler.Next;
                }
            return array;

        }
        public void AnzahlListeAusgeben()
        {
            int counter = 0;

            Element<T> zaehler = first;
            while (zaehler != null)
            {
                counter++;
                zaehler = zaehler.Next;
            }
            Console.WriteLine(counter);
        }


    }
}