using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SimpleListIndexer
{
    public class SimpleList<T> where T: IComparable
    {
        public Element first;
        public Element last;
        public SimpleList()
        {

        }
        public SimpleList this[int index]
        {
            get { return this[index]; }
        }

        public void Add(Element element)
        {
            Element neu = new Element(element.Name);

            if (first == null)
            {
                first = neu;
            }

            else
            {
               first.next = neu;
                last = neu;
            }


        }

        public void Delete(Element element)
        {
            
            
        }

        public Element Search(Element element)
        {
            foreach (Element elementarr in this.ToArray())
            {
                if(element.Name.CompareTo(elementarr.Name) == 0)
                {
                    return elementarr;
                }
                
            }
            return null;
            
        }

        public void Print()
        {
            foreach (Element element in this.ToArray())
            {
                Console.WriteLine(element);
            }
        }



        public Element[] ToArray()
        {
            int counter = 0;
            
            while (first.next != null)
            {
                counter++;
            }

            Element[] array = new Element[counter];

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    array[i] = first;
                }
                else
                {
                    array [i] = first.next;
                }
            }
            return array;


        }
    }
}