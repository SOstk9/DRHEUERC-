using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Postsendung
{
    public class Adresse
    {
        private string _nachname;
        private string _vorname;
        private string _straßeNr;
        private string _plzOrt;
        private string _land;

        public Adresse(string nachname, string vorname, string straßeNr, string plzOrt, string land = "Deutschland")
        {
            _nachname = nachname;
            _vorname = vorname;
            _straßeNr = straßeNr;
            _plzOrt = plzOrt;
            _land = land;
        }

        public bool IstGueltig()
        {
            if (this._nachname == "" || this._vorname == "" || this._straßeNr == "" || this._plzOrt == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string GetNachname()
        {
            return _nachname;
        }

        public string GetVorname()
        {
            return _vorname;
        }

        public string GetStraßeNr()
        {
            return _straßeNr;
        }

        public string GetPLZOrt()
        {
            return _plzOrt;
        }
        public string GetLand()
        {
            return _land;
        }

        public string ToString()
        {
            string tanga = this.GetVorname().ToString() + "\n" + this.GetNachname().ToString() + "\n" + this.GetStraßeNr().ToString() + "\n" + this.GetPLZOrt().ToString();
            return tanga;
        }
    }
}