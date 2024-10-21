using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Postsendung
{
    public abstract class Postsendung
    {
        VersandService versandService;
        protected Adresse _absender;
        protected Adresse _empfaenger;


        public Postsendung(VersandService versendi, Adresse absender, Adresse empfaenger)
        {
            versandService = versendi;
            _absender = absender;
            _empfaenger = empfaenger;
        }



        public int GetID()
        {
            return versandService.GetID();
        }


        public Adresse GetAbsender()
        { return _absender; }


        public Adresse GetEmpfaenger()
        { return _empfaenger; }

        public bool DarfAusliefern()
        {
         

            if(versandService.GetZugestellt() == false && _empfaenger.IstGueltig() == true)
            {
               
                
                return true;
            }
            else
            {
                return false;
            }
            

        }
        public virtual void SetzeStation(Station station)
        { 
        
        }

        public abstract string ToString();

        public void SetZugestellt(bool zugestellt)
        {
            this.versandService.SetZugestellt(zugestellt);

        }
    }
}