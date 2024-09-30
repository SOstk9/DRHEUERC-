using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Warteschlange
{
    internal class MyLinkedQueue
    {
        private Entry _head;
        private Entry _tail;


        public Entry GetHead()
        {
            return _head;
        }

        public Entry GetTail()
        {
            return _tail;
        }


        public bool IsEmpty()
        {
            if (this == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Entry Enqueue(string data)
        {
            Entry entry = new Entry(data);

            if (_head == null)
            {
                _head = entry;
            }
            else if (_head != null)
            {             
                _tail = entry;
                _head.SetNext(_tail);
            }
            else
            {   _tail.SetNext(entry);
                _tail = entry;
            }
            return entry;
       
        }

        public void Print()
        {

            // Entry mumie;

            _head.GetName();
            Entry entry = _head.GetNext();
            while (entry != null)
            {
                entry.GetName();
                entry = entry.GetNext();
            }





        }

        public string Dequeue()
        {
            string head;
            if (this == null)
            {
                return null;
            }
            else
            {
                head = _head.GetName();
                _head = null;
                return head;

            }
        } 
    }
}
