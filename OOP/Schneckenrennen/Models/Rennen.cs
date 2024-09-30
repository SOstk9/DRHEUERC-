using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schneckenrennen.Models
{
    internal class Rennen
    {
        private string _name;
        private int _maxAnzahlSchnecken;
        private List<Rennschnecke> _teilnehmendeSchnecken = new List<Rennschnecke>();
        private int _laengeStrecke;
        private Rennschnecke rennschnecke;

        public Rennen(string name, int maxAnzahlSchnecken, int laengeStrecke)
        {
            _name = name;
            _maxAnzahlSchnecken = maxAnzahlSchnecken;
            _laengeStrecke = laengeStrecke;
        }

        public void AddRennschnecke(Rennschnecke neueSchnecke)
        {
            _teilnehmendeSchnecken.Add(neueSchnecke);

            //for (int i = 0; i < _teilnehmendeSchnecken.Count; i++)
            //{
            //    if (neueSchnecke.GetName() == _teilnehmendeSchnecken[i].GetName())
            //    {
            //        _teilnehmendeSchnecken.Remove(neueSchnecke);
            //    }

            //}
        }


    
        

        public string Ausgabe()
        {
            string ausgabe = "\nRennname: " + _name + "\n" + "Maximale Schneckenanzahl: " + _maxAnzahlSchnecken + "\n" + "Streckenlänge: " + _laengeStrecke + "\n";
            return ausgabe;
        }

        public string AusgabeSchneckenNamen()
        {
            string name = "";
            foreach (Rennschnecke rennschnecke in _teilnehmendeSchnecken)
            {
                name = "\n" + name + rennschnecke.GetName() + "\n";
                
            }
            return name;
        }

        public string ErmittleGewinner()
        {
            string gewinner;
           foreach (Rennschnecke rennschnecke in _teilnehmendeSchnecken)
            {
                if (rennschnecke.WegZurueckgelegt() >= _laengeStrecke)
                {
                    gewinner = rennschnecke.GetName();
                    return gewinner;
                }
                else
                {
                    
                }
            }
            return null;


        }

        public void LasseSchneckenKriechen()
        {
            foreach (Rennschnecke rennschnecke in _teilnehmendeSchnecken)
            {
                rennschnecke.Krieche();
            }

        }

        public void Durchfuehren()
        {
            string gewinner = ErmittleGewinner();
            while (gewinner == null)
            {
                LasseSchneckenKriechen();
                gewinner = ErmittleGewinner();
            }
        }

        public bool IstRennteilnehmer(string schneckenname)
        {

            for (int i = 0; i < _teilnehmendeSchnecken.Count; i++)
            {
                if (schneckenname == _teilnehmendeSchnecken[i].GetName())
                {
                    return true;
                }
                else
                {
                 
                }

            }
            return false;
        
        }
    }
}
