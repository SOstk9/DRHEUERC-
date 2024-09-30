﻿using System;
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
        private List<Rennschnecke>  _teilnehmendeSchnecken;
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
            for (int i = 0; i < _maxAnzahlSchnecken; i++)
            {
                if (_teilnehmendeSchnecken[i] == null)
                {
                    _teilnehmendeSchnecken[i] = neueSchnecke;
                }
             }
        }

        public string Ausgabe()
        {
            string ausgabe = _name + " " + _maxAnzahlSchnecken + " " + _laengeStrecke + " ";
            return ausgabe;
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
                    return null;
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
            while (ErmittleGewinner == null)
            {
                LasseSchneckenKriechen();
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