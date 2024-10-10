namespace Vereinskostenstruktur
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AmateurSportler kaminski = new AmateurSportler("Marcin Kaminski", 1);
            SpitzenSportler lasme = new SpitzenSportler("Bryan Lasme", 10);
            Trainer reis = new Trainer("Thomas Reis", 8);

            UnterstuetzendesMidglied geraerts = new UnterstuetzendesMidglied("Kare Geraerts");


            Vorstandsmitglied schweppe = new Vorstandsmitglied("Schweppmeister", 10);


            Verein schalke = new Verein("schalke", 5);


            schalke.MitgliedHinzufuegen(kaminski);
            schalke.MitgliedHinzufuegen(lasme);
            schalke.MitgliedHinzufuegen(reis);
            schalke.MitgliedHinzufuegen(geraerts);
            schalke.MitgliedHinzufuegen(schweppe);

            //sollte Fehlermeldung kommen, da maximale Mitgliederanzahl erreicht
            schalke.MitgliedHinzufuegen(schalke);


            //Einnahmen und Ausgaben
            Console.WriteLine(kaminski.GetEinnahmen());
            Console.WriteLine(kaminski.GetAusgaben());
            Console.WriteLine(kaminski.GetUeberschuss() + "\n");

            Console.WriteLine(lasme.GetEinnahmen());
            Console.WriteLine(lasme.GetAusgaben());
            Console.WriteLine(lasme.GetUeberschuss() + "\n");

            Console.WriteLine(reis.GetEinnahmen());
            Console.WriteLine(reis.GetAusgaben());
            Console.WriteLine(reis.GetUeberschuss() + "\n");

            Console.WriteLine(geraerts.GetEinnahmen());
            Console.WriteLine(geraerts.GetAusgaben());
            Console.WriteLine(geraerts.GetUeberschuss() + "\n");

            Console.WriteLine(schweppe.GetEinnahmen());
            Console.WriteLine(schweppe.GetAusgaben());
            Console.WriteLine(schweppe.GetUeberschuss() + "\n");

            Console.WriteLine(schalke.GesamtEinnahmenBerechnen());
            Console.WriteLine(schalke.GesamtAusgabenBerechnen());
            Console.WriteLine(schalke.UeberschussBerechnen());

            schalke.Ausgabe();




            Console.ReadLine();


        }
    }
}
