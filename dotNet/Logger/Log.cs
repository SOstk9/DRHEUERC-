using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public delegate void LogHandler(string log);
    internal class Log
    {

        string _log;
        string _zielpfad;

        public Log (string zielpfad)
        {
            _zielpfad = zielpfad;

        }

        public void Schreiben(string log)
        {
            File.AppendAllText(_zielpfad, log);
        }

        public void Quit()
        {
           
        }


    }
}
