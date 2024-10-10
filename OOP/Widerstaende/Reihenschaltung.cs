namespace Widerstaende
{
    public class Reihenschaltung : Widerstandsnetz
    {

        public Reihenschaltung(params Widerstand[] widerstand) : base(widerstand)
        {
            string _name = "Rr";

            for (int i = 0; i < widerstand.Length; i++)
            {
                _name = _name + " " + widerstand[i].GetName();
            }
            Console.WriteLine(_name);
            Widerstandsberechnung();
        }
        public override double Widerstandsberechnung()
        {
            foreach (Widerstand widerstand in _widerstandliste)
            {
                _widerstand = _widerstand + widerstand.GetWiderstand();
            }
            return _widerstand;
        }
    }
}