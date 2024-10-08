using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Der_Picknicker_von_Leipniz
{
    public class Auto : Fahrzeug
    {
      
        public Auto(bool antenneEingefahren, string kennzeichen = "DO-OM 3", int kilometerstand = 0, int anzahlSitzplätze = 5)
        {
            _kennzeichen = kennzeichen;
            _kilometerstand = kilometerstand;
            _anzahlSitzplätze = anzahlSitzplätze;
            _antenneEingefahren = antenneEingefahren;
        }

        public override void VorDemWaschen()
        {
            _antenneEingefahren = true;
            Console.WriteLine("Antenne ist für das Waschen eingefahren!");
        }

    }
}