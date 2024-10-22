using System;

namespace Zuege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train z1 = new Train();
            Train a4 = new Train();
            Train i9 = new Train();

            RailwayStation FrankfurtHbf = new RailwayStation();

            try
            {
                //FrankfurtHbf.ZugAusfahren();

                z1.Zugnummer = 1;
                z1.AnzahlWaggons = 4;

                a4.Zugnummer = 2;
                a4.AnzahlWaggons = 4;

                i9.Zugnummer = 3;
                i9.AnzahlWaggons = 3;


                FrankfurtHbf.ZugKapazitaet = 10;
                FrankfurtHbf.ZugHinzufuegen(z1);
                FrankfurtHbf.ZugHinzufuegen(a4);
                FrankfurtHbf.ZugHinzufuegen(i9);

                FrankfurtHbf.ZugAusfahren();
                FrankfurtHbf.ZugAusfahren();
            }
            catch (RainwayStationException e)
            {
                Console.WriteLine(e.Message);
            }



            Console.ReadLine();
        }
    }
}
