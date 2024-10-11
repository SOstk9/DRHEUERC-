using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Postsendung
{
    public class Paket : Postsendung
    {
        private float _gewicht;
        private bool _versicherung;


        public Paket(VersandService versandService, Adresse absender, Adresse empfaenger, float gewicht, bool versicherung) : base(versandService,absender,empfaenger)
        {
            _gewicht = gewicht;
            _versicherung = versicherung;
        }


        public float GetGewicht()
        {
            return _gewicht;
        }

        public bool GetVersicherung()
        {
            return _versicherung;
        }
        public override void SetzeStation(Station station)
        {

        }
        public override string ToString()
        {
            string tanga = this.GetID().ToString() + this.GetAbsender().ToString() + this.GetEmpfaenger().ToString() + GetGewicht().ToString() + GetVersicherung().ToString();
            return tanga;
        }
    }

   
}