using Schneckenrennen.Models;

namespace Schneckenrennen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rennschnecke uwe = new Rennschnecke("Uwe", 20);
            Rennschnecke heinrich = new Rennschnecke("Heinrich", 18);

            Rennen speedo = new Rennen("Speedo", 4, 40);
            speedo.AddRennschnecke(uwe);
            speedo.AddRennschnecke(heinrich);

        }
    }
}
