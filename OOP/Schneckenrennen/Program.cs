using Schneckenrennen.Models;

namespace Schneckenrennen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Schnecken erstellt
            Rennschnecke uwe = new Rennschnecke("Uwe", 20);
            Rennschnecke heinrich = new Rennschnecke("Heinrich", 18);

            //Rennen erstellt
            Rennen speedo = new Rennen("Speedo", 4, 40);

            //Wettbüro erstellt
            Wettbuero interWetten = new Wettbuero(speedo, 2, "interWetten");

            //Schnecken zum Rennen hinzugefügt
            speedo.AddRennschnecke(uwe);
            speedo.AddRennschnecke(heinrich);

            ////testen, ob doppelte gehen
            //speedo.AddRennschnecke(uwe);

            //Wird geguckt, ob es einen Gewinner gibt, wenn es funktioniert, muss jetzt hier 0 rauskommen
            speedo.ErmittleGewinner();

            //Wettinfos werden ausgegeben
            string wettbuero = interWetten.Ausgabe();
            Console.WriteLine(wettbuero);

            //Wette platzieren
            interWetten.WetteAnnehmen(speedo, uwe.GetName(), 10, "Markus");

            //Rennen wird gefahren
            speedo.Durchfuehren();

            //Gewinner wird ausgegeben
            string gewinner = speedo.ErmittleGewinner();
            Console.WriteLine($"der Gewinner ist : {gewinner}");

            //Wettergebnis
            Console.WriteLine(interWetten.WetteGewonnen(0));






            Console.ReadLine();

        }
    }
}
