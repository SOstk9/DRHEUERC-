using System;

namespace SimpleList
{
    public class Element<T> where T : IComparable
    {
        T _first;
        Element<T> _next;

        public Element(T first)
        {
            _first = first;
         

        }

        public void SetNext(Element<T> neu)
        {
            _next = neu;
        }
  


    }
}