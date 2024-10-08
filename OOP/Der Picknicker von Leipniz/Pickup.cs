using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Der_Picknicker_von_Leipniz
{
    public class Pickup : Auto
    {
        private int _ladeflaeche;
        private int _beladenStatus;

        public Pickup(bool antenneEingefahren, int beladenStatus = 0, int ladeflaeche = 0, string kennzeichen = "DO-OM 3", int kilometerstand = 0, int anzahlSitzplaetze = 2) : base(antenneEingefahren, kennzeichen, kilometerstand, anzahlSitzplaetze)
        {
            _ladeflaeche = ladeflaeche;
            _beladenStatus = beladenStatus;
        }

        public int Beladen(int beladen)
        {
            if(_beladenStatus <= _ladeflaeche)
            {
                _beladenStatus = _beladenStatus + beladen;
                return _beladenStatus;
            }
            else
            {
                Console.WriteLine("Kein Platz mehr!");
                return _beladenStatus;
            }
        }

        public bool Entladen(int beladen)
        {
            if (_beladenStatus >= beladen)
            {
                _beladenStatus = _beladenStatus - beladen;
                return true;
            }
            else
            {
                Console.WriteLine("So viel is nich drauf!");
                return false;
            }
        }

        public override void VorDemWaschen()
        {
            _antenneEingefahren = true;
            _beladenStatus = 0;
            Console.WriteLine("Antenne ist für das Waschen eingefahren und die Ladefläche entleert!");

        }

        public int GetLadung()
        {
            return _beladenStatus;
        }
    }
}