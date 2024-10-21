namespace Postsendung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Versandservice erstellen
            VersandService dhschnell = new VersandService();
            //Adressen zum Testen
            Adresse absender = new Adresse("Ostkotte", "Sven", "Sperlingstraße 9", "48607 Ochtrup");
            Adresse empfaenger = new Adresse("Claus", "Santa", "Am Nordpol 1", "11111 Nordpol City", "Nordpol");

            //Ausgabe Adresse, zur Überprüfung
            Console.WriteLine(absender.ToString());

            //Zwischenstation wird erstellt
            Station zwischenstelle = new Station("44787 Bochum");

            //Verfolgbares Paket wird erstellt
            dhschnell.NeuerBrief(absender, empfaenger, Briefkategorie.Eilbrief);
            dhschnell.NeuesVerfolgbaresPaket(absender, empfaenger, 5, true);

            //Zwischenstation wird gesetzt
            dhschnell.GetListe()[1].SetzeStation(zwischenstelle);

            Console.WriteLine(dhschnell.GetListe()[1].ToString());


            Console.ReadLine();
        }
    }
}
