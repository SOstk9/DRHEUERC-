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
        }

        public void Add(Element<T> item)
        {


            if (first == null)
            {
                first = item;
            }
            else if (first != null)
            {
                last.SetNext(item);
                last = item;
            }



        }



        public void DeleteList()
        {
            first = null;
            while (last != null)
            {
                last = null;
            }

        }

        public void SearchList()
        {

        }

        public void ListeAusgeben()
        {
            Console.WriteLine(first);

        }

        public void CreateArrayFromList()
        {

            foreach (var item in this)
            {

            }
        }


    }
}