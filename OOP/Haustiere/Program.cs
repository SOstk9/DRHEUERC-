using System.Runtime.InteropServices.ObjectiveC;
using System.Security.Cryptography.X509Certificates;

namespace Haustiere
{
    internal class Program
    {
       static Haustier[] haustiere = new Haustier[6];
        static void Main(string[] args)
        {
            
            Anlegen();
            Katze garfield = haustiere[4] as Katze;
            Console.WriteLine(garfield.Vogel());
            haustiere[4] = garfield;
            NeuerLieblingsVogel();
            garfield = haustiere[4] as Katze;
            Console.WriteLine(garfield.Vogel());
            haustiere[4] = garfield;
     
            Console.ReadLine();
            

            

            
        }

        static void Anlegen()
        {

            Hund justus = new Hund("Dalmatiner", "Justus", 4000.0);
            Hund podrick = new Hund("Fußhupe", "Podrick", 200.0);
            Vogel donald = new Vogel(false, "Donald", 250.0);
            Vogel dagobert = new Vogel(true, "Dagobert", 300.0);
            Katze garfield = new Katze(donald, "Garfield", 2500.0);
            Katze tom = new Katze(dagobert, "Tom", 500.0);


            haustiere[0] = justus;
            haustiere[1] = podrick;
            haustiere[2] = donald;
            haustiere[3] = dagobert;
            haustiere[4] = garfield;
            haustiere[5] = tom;

        }
        static void NeuerLieblingsVogel()
        {
            for (int i = 0; i < haustiere.Length; i++)
            {
                if (haustiere[i] is Vogel)
                {
                    for (int j = 0; j < haustiere.Length; j++)
                    {
                        if (haustiere[j] is Katze)
                        {
                            Katze katze = haustiere[j] as Katze;
                            Vogel vogel = haustiere[i] as Vogel;
                            katze.SetLieblingsVogel(vogel);
                            haustiere[j] = katze;
                        }
                    }
                }
            }

        }
        static void Ausgeben()
        {
            foreach (Haustier haustier in haustiere)
            {
                Console.WriteLine($"Der Typ des Tieres ist {haustier.GetType()}, die Beschreibung lautet: {haustier.Beschreibung()} und die Tierarztkosten sind: {haustier.GetKosten()}");
            }
        }
    }
}
