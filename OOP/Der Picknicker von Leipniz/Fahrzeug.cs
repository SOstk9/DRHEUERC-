using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Der_Picknicker_von_Leipniz
{
    public abstract class Fahrzeug
    {
        protected string _kennzeichen;
        protected int _kilometerstand;
        protected int _anzahlSitzplätze;
        protected bool _antenneEingefahren;

         public void GetKennzeichen()
        {
            Console.WriteLine(_kennzeichen);
        }

        public void GetKilometerstand()
        {
            Console.WriteLine(_kilometerstand);
        }

        public void Fahre(int kilometer)
        {
            _kilometerstand = _kilometerstand + kilometer;
            Console.WriteLine(_kilometerstand);
        }

        public void AntenneEinfahren()
        {
            _antenneEingefahren = true;
            Console.WriteLine("Antenne ist eingefahren");
        }

        public void AntenneAusfahren()
        {
            _antenneEingefahren = false;
            Console.WriteLine("Antenne ist ausgefahren");
        }

        public bool IstAntenneDraußen()
        {
            return _antenneEingefahren;
        }

        public abstract void VorDemWaschen();

        public void Waschen()
        {
            VorDemWaschen();
            Console.WriteLine("Auto wird gewaschen!");
        }

        public int GetSitzplaetze()
        {
            return _anzahlSitzplätze;
        }
    }
}