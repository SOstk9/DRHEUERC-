using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Postsendung
{
    public class Station
    {
        private string _ort;
        private DateTime _zeitstempel;

        public Station(string ort)
        {
            _ort = ort;
            _zeitstempel = DateTime.Now;
        }

        public void SetOrt(string ort)
        {
            _ort = ort;
        }

        public string ToString()
        {
            return _ort + _zeitstempel.ToString();
        }
    }
}