using Zahnarztpraxis.Models;

namespace Zahnarztpraxis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Krankenkasse techniker = new Krankenkasse(1, "techniker");
            Krankenkasse ikk = new Krankenkasse(2, "ikk");

            KassenPatient ulli = new KassenPatient(1, "Ulli", "19.10.1995", techniker);
            KassenPatient ulbertus = new KassenPatient(2, "Ulbertus", "15.03.1958", ikk);
            KassenPatient herbert = new KassenPatient(3, "Herbert", "07.08.1993", techniker);

            Console.WriteLine(ulbertus.GetKrankenkasse().AusgabeKrankenkasse());
            Console.WriteLine(herbert.AusgabePatient());
            Console.ReadLine();

        }
    }
}
