using System.Linq;
using System.Text.Json;

namespace jsooooonjoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pfad1 = @"C:\Users\ITA5-TN15\OneDrive - IT-Akademie Dr. Heuer GmbH\Programmieren\dotNet\jsooooonjoin\alleArtikel.json";
            string pfad2 = @"C:\Users\ITA5-TN15\OneDrive - IT-Akademie Dr. Heuer GmbH\Programmieren\dotNet\jsooooonjoin\bestellung.json";

            string fileBestellung = File.ReadAllText(pfad2);
            string fileArtikel = File.ReadAllText(pfad1);

            double summe = 0;

            Bestellung listBestellung = JsonSerializer.Deserialize<Bestellung>(fileBestellung);
            List<alleArtikel> listArtikel = JsonSerializer.Deserialize<List<alleArtikel>>(fileArtikel);


            var query = from akl in listArtikel
                        join best in listBestellung.AllePositionen
                        on akl.Artikelnummer equals best.Artikelnummer
                        select new
                        {
                            NUMMER = akl.Artikelnummer,
                            NAME = akl.Name,
                            ANZAHL = best.Anzahl,
                            SUMME = best.Anzahl * akl.Preis

                        };
            Console.WriteLine("{0, -4} {1,-40} {2,-8} {3,5}", "Nr", "Name", "Anzahl", "Summe");
            foreach (var work in query)
            {
                Console.WriteLine("________________________________________________________________________");
                Console.WriteLine($"{0, -4} {1,-40} {2,-8} {3,5}, {work.NUMMER}  , {work.NAME}, {work.ANZAHL}, {work.SUMME}" );
                summe += work.SUMME; 
            }
            
            Console.WriteLine("\n========================================================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Gesamtsumme: {summe}");
            Console.ResetColor();
        }
    }
}
