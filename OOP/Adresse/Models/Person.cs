using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Adresse.Models
{
    internal class Person
    {
        private string _nachname;
        private string _vorname;
        private int _alter;
        private Adresse _adresse;
        private Hund _hund;

        public Person(string nachname, string vorname, int alter)
        {
            _nachname = nachname;
            _vorname = vorname;
            _alter = alter;
            
        }
        


        public string Vorname()
        {
            return _vorname;
        }
   

        public void Nachname(string nachname)
        {
            _nachname = nachname;
           
        }

        public int Alter()
        {
            return _alter;
        }

        public void SetAddress(string straße, string hausnr, string plz, string ort)
        {
            _adresse = new Adresse(straße, hausnr, plz, ort);
        }
        public void SetHund(Hund hund)
        {
            _hund = hund;
        }
        public void GibPersonAus()
        {
            Console.WriteLine(this._nachname);
            Console.WriteLine(this._vorname);
            Console.WriteLine(this._alter);
            this._adresse.AusgabeAdresse();
            
           
        }
        public Hund GetHund()
        {
            return _hund;
        }
        public Adresse Address()
        {
            return _adresse;
        }

    
    }
}
