using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Postsendung
{
    public class Brief : Postsendung
    {
        Briefkategorie briefe = new Briefkategorie();
        public Brief (VersandService versandService, Adresse absender, Adresse empfaenger, Briefkategorie briefkategorie = Briefkategorie.Standardbrief) : base(versandService,absender,empfaenger)
        {
            briefe = briefkategorie;
        }

        public Briefkategorie GetBriefkategorie()
        {
            return briefe;
        }

        public override string ToString()
        {
            string tanga = this.GetID().ToString() + this.GetAbsender().ToString() + this.GetEmpfaenger().ToString() + GetBriefkategorie().ToString();
            return tanga;
        }

    }
}