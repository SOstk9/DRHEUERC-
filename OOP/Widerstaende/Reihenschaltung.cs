namespace Widerstaende
{
    public class Reihenschaltung : Widerstandsnetz
    {

        public Reihenschaltung(params Widerstand[] widerstand) : base()
        {

            this._name = ErstelleName(widerstand);



        }
        public override double Widerstandsberechnung()
        {
            foreach (Widerstand widerstand in _widerstandliste)
            {
                _widerstand = _widerstand + widerstand.GetWiderstand();
            }
            return _widerstand;
        }
        public string ErstelleName(params Widerstand[] widerstand)
        {
            string _name = "Rr";
            for (int i = 0; i < widerstand.Length; i++)
            {
                _name = _name + " " + widerstand[i].GetName();
            }
            return _name;

        }
    }
}