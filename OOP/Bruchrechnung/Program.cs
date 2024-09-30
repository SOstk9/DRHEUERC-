using Bruchrechnung.Models;

namespace Bruchrechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bruch zaehler = new Bruch(2);
            Bruch beide = new Bruch(10,20);

            zaehler.Ausgabe();
            //zaehler.Kehrwert();
            //zaehler.Ausgabe();

            beide.Ausgabe();
            //beide.GemeinsamerTeiler(beide.AusgabeZaehler(),beide.AusgabeNenner());
            //beide.Ausgabe();
            //beide.Kuerzen();
            //beide.Ausgabe();

            string addierterBruch = zaehler.Addiere(beide);
            Bruch subtrahierterBruch = zaehler.Subtrahiere(beide);
            Console.WriteLine(addierterBruch);
            subtrahierterBruch.AusgabeBruch();

            //string multiplizierterBruch = zaehler.Multipliziere(beide);
            //Console.WriteLine(multiplizierterBruch);

            //string dividierterBruch = zaehler.Dividiere(beide);
            //Console.WriteLine(dividierterBruch);


            Console.ReadLine();

        }
    }
}
