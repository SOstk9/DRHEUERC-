using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SimpleList
{
    public class SimpleList<T> where T : IComparable 
    {
        Element<T> first;
        Element<T> last;
        Element<T> element;
      

        public SimpleList()
        {

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
            else
            {
                last.SetNext(item);
                last = item;
            }
            //return el1;

              

            }
           
        

        public void DeleteList()
        {
            foreach (var item in this)
            {

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