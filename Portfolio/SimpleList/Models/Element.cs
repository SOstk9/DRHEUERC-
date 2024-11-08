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

        public T First
        {
            get { return _first; }
            
        }

        public Element<T> Next
        {
            get { return _next; }
            set { _next = value; }
        }


        public void SetNext(Element<T> neu)
        {
            _next = neu;
        }
  


    }
}