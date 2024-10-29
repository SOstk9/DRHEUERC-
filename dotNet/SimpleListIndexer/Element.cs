using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleListIndexer
{
    public class Element<T>
    {   
        public T Name { get; set; }
        public Element next { get; set; }
        public Element previous { get; set; }

        public Element(string name, Element Next = null, Element Previous = null )
        {
            Name = name;
        }
    }
}