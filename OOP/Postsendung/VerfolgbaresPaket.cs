using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Postsendung
{
    public class VerfolgbaresPaket : Paket
    {
        private List<Station> stationsListe = new List<Station>();


        public VerfolgbaresPaket(VersandService versandService, Adresse absender, Adresse empfaenger, float gewicht, bool versicherung) : base (versandService,absender,empfaenger,gewicht,versicherung)
        {
            Station station = new Station(absender.GetPLZOrt());
            stationsListe.Add(station);
        }

        public override void SetzeStation(Station station)
        {
            stationsListe.Add(station);
        }

        public string ToString()
        {
            string liste = "";
            foreach (Station station in stationsListe)
            {
                liste = liste + "\n" + station.ToString();
            }
            return liste;
        }
    }
}