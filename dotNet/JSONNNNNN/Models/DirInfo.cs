using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONNNNNN.Models
{
    internal class DirInfo
    {
        static string _pfad = "C:\\";
        string _anlegeDatum { get; set; }
        int _anzahlDateien {get; set; }

        List<string> directories = new List<string>(Directory.EnumerateDirectories(_pfad));

        public DirInfo()
        {

        }

        public DirInfo(string pfad)
        {
            _pfad = pfad;
        }


        public void Dateien()
        {
            foreach (var dir in directories)
            {
                _anzahlDateien++;
                //_anlegeDatum = Directory.GetCreationTime();
                this.ToString();
            }
            
        }


        public override string ToString()
        {
            return $"{_pfad} Angelegt: {_anlegeDatum} Anzahl Dateien{_anzahlDateien}";
        }


    }
    


}
