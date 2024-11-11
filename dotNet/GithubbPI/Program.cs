using System.Diagnostics;

namespace GithubPi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Ausgabe zum Vergleich
            Console.WriteLine(Math.PI);

            //Variablen deklarieren
            double pi = 0;
            const int anzahlAufrufe = 4; //Anzahl der gleichzeitigen Threads

            //Uhr zum Messen der Laufzeit
            Stopwatch sw = new Stopwatch();
            //neuer Task
            Task<double> task = null;
            //Liste, in der die Tasks später gesammelt werden, um parallel laufen zu können
            List<Task<double>> tasks = new List<Task<double>>();

            //Stoppuhr starten
            sw.Start();


            //Tasks werden erstellt und der Liste hinzugefügt
            for (int i = 0; i < anzahlAufrufe; i++)
            {
               
               task = Task.Run(() => PI_Berechnung(i, anzahlAufrufe));
               tasks.Add(task);

            }
            
            //Es wird gewartet, bis alle Tasks ausgeführt sind
            Task.WaitAll(tasks.ToArray());


            //in der später ausgegebenen Variable Pi werden die Ergebnisse der einzelnen Tasks addiert
            foreach(Task<double> t in  tasks)
            {
                pi += t.Result;
            }


            //Stoppen der Zeit
            sw.Stop();


            //Ausgabe Pi
            Console.WriteLine(pi);

            Console.WriteLine("Dauer {0:N0} Millisekunden", sw.ElapsedMilliseconds);
        }






        //Berechnung nach John Machin (http://de.wikipedia.org/wiki/John_Machin)
        private static double PI_Berechnung(int startwert, int schrittweite)
        {
            const double durchlaeufe = 1_000_000_000;
            double x, y = 1 / durchlaeufe;
            double summe = 0;
            double pi;

            for (double i = startwert; i <= durchlaeufe; i += schrittweite)
            {
                x = y * (i - 0.5);
                summe += 4.0 / (1 + x * x);
            }

            pi = y * summe;

            return pi;
        }
    }
}