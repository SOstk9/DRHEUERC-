using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class Flasche<T> where T: Getränk
    {
        T _inhalt;

        public Flasche(T inhalt)
        {
            _inhalt = inhalt;
        }

        public bool IstLeer()
        {
            if (_inhalt is null)
            {
                return true;
            }
            else
            {
                
                return false;
            }
        }

        public void Füllen(T inhalt)
        {
            if (_inhalt is null)
            {
                _inhalt = inhalt;
            }
            
        }

        public void Leeren()
        {
            if (_inhalt != null)
            {
                _inhalt = null;
            }
        }
    }
}