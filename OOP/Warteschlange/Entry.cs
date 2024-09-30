using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warteschlange
{
    internal class Entry
    {
        private string _data;
        private Entry _next;

        public Entry(string data, Entry next = null)
        {
            _data = data;
            _next = next;

        }

        public string GetName()
        {
            return _data;
        }

        public Entry GetNext()
        {
            return this;
        }

        public void SetName(string data)
        {
            this._data = data;
        }

        public void SetNext(Entry next)
        {
            this._next = next;
        }
    }
}
