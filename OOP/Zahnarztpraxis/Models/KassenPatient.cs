using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahnarztpraxis.Models
{
    internal class KassenPatient
    {
        private int _id;
        private string _name;
        private string _adresse;
        private DateTime _geburtstag;
        private bool versichertenKartevorgelegt;
        private Krankenkasse _krankenkasse;

        public KassenPatient(int id, string name, string geburtstag, Krankenkasse krankenkasse)
        {
            string[] geb = geburtstag.Split('.');
            int tag = int.Parse(geb[0]);
            int monat = int.Parse(geb[1]);
            int jahr = int.Parse(geb[2]);
            DateTime dt = new DateTime(jahr, monat, tag);
            _id = id;
            _name = name;
            _geburtstag = dt;
            _krankenkasse = krankenkasse;

        }
        public string AusgabePatient()
        {
            string ausgabe = this._id.ToString() + " " + this._name + " ist bei der " + this._krankenkasse.AusgabeKrankenkasse() + "und am " + _geburtstag + "geboren.";
            return ausgabe;
        }
        public Krankenkasse GetKrankenkasse()
        {
            return _krankenkasse;
        }


    }
}
