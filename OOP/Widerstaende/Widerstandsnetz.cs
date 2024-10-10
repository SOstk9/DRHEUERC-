namespace Widerstaende
{
    public abstract class Widerstandsnetz : Widerstand
    {
        protected double _gesamtwiderstand;
        //protected string _name = "";
        protected List<Widerstand> _widerstandliste = new List<Widerstand>();

        public Widerstandsnetz(params Widerstand[] widerstand)
        {
            for (int i = 0; i < widerstand.Length; i++)
            {
                _widerstandliste.Add(widerstand[i]);
            }

            Widerstandsberechnung();
        }

        public abstract double Widerstandsberechnung();

    }
}