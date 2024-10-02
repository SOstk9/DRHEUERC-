using GehaltsrechnerFirma_Vererbung.Models;

namespace GehaltsrechnerFirma_Vererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Praktikant eins = new Praktikant("Entwicklung", "Grau-Mähne", "Ulfgard", 56);
            eins.Gehaltsberechnung();
            Console.WriteLine(eins.GetGehalt());

            Angestellter zwei = new Angestellter("A", "Graufreud", "Theon", 21);
            zwei.Gehaltsberechnung();
            Console.WriteLine(zwei.GetGehalt());

            ExternerMitarbeiter drei = new ExternerMitarbeiter(200, "der Graue", "Gandalf", 1578);
            drei.Gehaltsberechnung();
            Console.WriteLine(drei.GetGehalt());

            Console.ReadLine();

        }
    }
}
