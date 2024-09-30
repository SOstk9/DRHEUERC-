namespace Bruchrechnung.Models
{
    internal class Bruch
    {
        private int _zaehler;
        private int _nenner;


        //Konstruktor

        public Bruch(int zaehler)
        {
            _zaehler = zaehler;
            _nenner = 1;
        }

        public Bruch(int zaehler, int nenner)
        {
            _zaehler = zaehler;
            _nenner = nenner;
        }



        //Funktionen
        public void Ausgabe()
        {
            string bruchDarstellung = _zaehler + "/" + _nenner;
            Console.WriteLine(bruchDarstellung);
        }

        public void Kehrwert()
        {
            int temp = _zaehler;
            _zaehler = _nenner;
            _nenner = temp;
        }

        private int GemeinsamerTeiler(int zaehler, int nenner)
        {
            if (nenner > 0)
            {
                return zaehler = GemeinsamerTeiler(nenner, zaehler % nenner);
            }
            else
            {
                return zaehler;
            }

        }


        public void Kuerzen()
        {
            int gemeinsamerTeiler = GemeinsamerTeiler(_zaehler, _nenner);
            _zaehler = _zaehler / gemeinsamerTeiler;
            _nenner = _nenner / gemeinsamerTeiler;
        }

        public string Addiere(Bruch zwei)
        {
            Bruch bruch1 = new Bruch(_zaehler, _nenner);

            string addierterBruch;

            int tempNennerEins = bruch1._nenner * zwei._nenner;
            int tempZaehlerEins = bruch1._zaehler * zwei._nenner;

            int tempNennerZwei = zwei._nenner * bruch1._nenner;
            int tempZaehlerZwei = zwei._zaehler * bruch1._nenner;

            bruch1._zaehler = tempZaehlerEins + tempZaehlerZwei;
            bruch1._nenner = tempNennerEins;

            Kuerzen();
            addierterBruch = bruch1._zaehler + " / " + bruch1._nenner;


            return addierterBruch;
        }

        public Bruch Subtrahiere(Bruch zwei)
        {
            Bruch bruch1 = new Bruch(_zaehler, _nenner);

            string subtrahierterBruch;

            int tempNennerEins = bruch1._nenner * zwei._nenner;
            int tempZaehlerEins = bruch1._zaehler * zwei._nenner;

            int tempNennerZwei = zwei._nenner * bruch1._nenner;
            int tempZaehlerZwei = zwei._zaehler * bruch1._nenner;

            bruch1._zaehler = tempZaehlerEins - tempZaehlerZwei;
            bruch1._nenner = tempNennerEins;

            Kuerzen();
            subtrahierterBruch = bruch1._zaehler + " / " + bruch1._nenner;



            return bruch1;
        }

        public string Multipliziere(Bruch zwei)
        {
            string multiplizierterBruch;

            int tempNennerEins = _nenner * zwei._nenner;
            int tempZaehlerEins = _zaehler * zwei._zaehler;


            _zaehler = tempZaehlerEins;
            _nenner = tempNennerEins;
            Kuerzen();
            multiplizierterBruch = _zaehler + "/" + _nenner;

            return multiplizierterBruch;


        }

        public string Dividiere(Bruch zwei)
        {
            string dividierterBruch;

            zwei.Kehrwert();


            int tempNennerEins = _nenner * zwei._nenner;
            int tempZaehlerEins = _zaehler * zwei._zaehler;


            _zaehler = tempZaehlerEins;
            _nenner = tempNennerEins;
            Kuerzen();
            dividierterBruch = _zaehler + "/" + _nenner;

            return dividierterBruch;
        }
        public int AusgabeZaehler()
        {
            return _zaehler;
        }
        public int AusgabeNenner()
        {
            return _nenner;
        }
        public void AusgabeBruch()
        {
            Console.WriteLine(_zaehler + "/" + _nenner);
        }
    }

}
