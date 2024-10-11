using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Postsendung
{
    public class VersandService
    {
        private List <Postsendung> posties = new List <Postsendung>();
        private bool _zugestellt;
        private int _id;
        
        public VersandService()
        {
            _id = 0;
        }
        public void NeuerBrief(Adresse absender, Adresse empfaenger, Briefkategorie briefkategorie)
        {
            _id++;
            Brief brief = new Brief(this, absender, empfaenger, briefkategorie);
            posties.Add(brief);
        }

        public void NeuesPaket(Adresse absender, Adresse empfaenger, float gewicht, bool versicherung)
        {
            _id++;
            Paket paket = new Paket(this, absender, empfaenger, gewicht, versicherung);
            posties.Add(paket);
        }

        public void NeuesVerfolgbaresPaket(Adresse absender, Adresse empfaenger, float gewicht, bool versicherung)
        {
            _id++;
            VerfolgbaresPaket paket = new VerfolgbaresPaket(this, absender, empfaenger, gewicht, versicherung);
            posties.Add(paket);
        }

        public void IstZugestellt()
        {
            foreach (Postsendung postsendung in posties)
            {
                if(postsendung.DarfAusliefern() == true && postsendung.GetAbsender().IstGueltig() == true)
                {
                    postsendung.SetZugestellt(true);
                }
                else
                {
                    postsendung.SetZugestellt(false);
                }
            }
        }

        public int GetID()
        {
            return _id;
        }
        public bool GetZugestellt()
        {
            return _zugestellt;
        }
        public bool SetZugestellt(bool zugestellt)
        {
            _zugestellt = zugestellt;
            return _zugestellt;
        }
        public List<Postsendung> GetListe()
        {

            return posties;

        }
    }
}