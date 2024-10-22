using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zuege
{
    public class RailwayStation
    {
        private int _name;
        private int _maxAnzahl;
        static int _waggonzaehler = 0;
        private List<Train> _zuege = new List<Train>();


        public int Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ZugKapazitaet
        {
            get { return _maxAnzahl; }
            set { _maxAnzahl = value; }
        }

        
        
        public void ZugHinzufuegen(Train train)
        {
           

            foreach (Train t in _zuege)
            {
                _waggonzaehler = _waggonzaehler + t.AnzahlWaggons;
            }

            if (_waggonzaehler < _maxAnzahl)
            {
                _zuege.Add(train);
                Console.WriteLine(train.Zugnummer + " wurde hinzugefügt!");
            }
            else
            {
                throw new RainwayStationException("train can't be added" + " " + train.Zugnummer);
            }
            
        }

        public void ZugAusfahren()
        {
            if (_zuege.Count != 0)
            {
                for (int i = 0;  i < _zuege.Count; i++)
                {
                    if (_zuege[i] == null)
                    {

                    }
                    else
                    {
                        Console.WriteLine(_zuege[0].Zugnummer + " ist ausgefahren!");
                        _waggonzaehler = _waggonzaehler - _zuege[i].AnzahlWaggons;
                        _zuege.RemoveAt(0);
                    }
                }

            }
            else
            {
                throw new RainwayStationException("no train in railwaystation!");
            }
        }
    }
}