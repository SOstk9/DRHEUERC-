namespace Flussman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fluss rhein =new Fluss("Rhein", 450);
            Fluss donau = new Fluss("Donau", 2000);

            //Rhein

            Stadt koeln = new Stadt("Köln");
            Stadt duesseldorf = new Stadt("Duesseldorf");

            //Donau

            Stadt ulm = new Stadt("Ulm");
            Schiff xaver = new Schiff("Xaver");
            Schiff franz = new Schiff("Franz");
            Klaerwerk strauss1 = new Klaerwerk("Strauß 1");


            rhein.WasserstandGeaendert += koeln.ReagiereWasserschutzwand;
            rhein.WasserstandGeaendert += duesseldorf.ReagiereWasserschutzwand;
            donau.WasserstandGeaendert += xaver.ReagiereAnhalten;

            rhein.Wasserstand = 999;
            donau.Wasserstand = 9000;



        }
    }
}
