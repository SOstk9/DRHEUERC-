namespace Linq
{
    internal class Produkt
    {
        public string _modell {get; set; }
        public string _preis { get; set; }
        public string _kategorie { get; set; }

        public Produkt(string modell, double preis, string kategorie)
        {
            _modell = modell;
            _preis = preis.ToString();
            _kategorie = kategorie;
        }
    }
}