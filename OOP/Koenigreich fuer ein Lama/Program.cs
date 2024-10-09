namespace Koenigreich_fuer_ein_Lama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Leibeigener bob = new Leibeigener("Bob", 2);
            Adel dagobert = new Adel("Dagobert", 50000);
            Buerger max = new Buerger("Max", 30);
            Koenig bran = new Koenig("Bran", 10000000);
            Steuereintreiber zachaeus = new Steuereintreiber("Zachäus", 20000);


            Console.WriteLine("Euer Gnaden, hier sind die diesjährigen Steuereinnahmen des Königreiches:");

            double steuer = bob.Steuer();
            Console.WriteLine($"Die Steuer von dem Abfall beträgt dieses Jahr: {steuer}");


            steuer = dagobert.Steuer();
            Console.WriteLine($"Die Steuer von Ser {dagobert.GetName()} beträgt: {steuer}");

            steuer = max.Steuer();
            Console.WriteLine($"Die Steuer von {max.GetName()} beträgt: {steuer}");

            steuer = bran.Steuer();
            Console.WriteLine($"Die Steuer von Euch beträgt: {steuer}");

            steuer = zachaeus.Steuer();
            Console.WriteLine($"Die Steuer von meiner Wenigkeit beträgt: {steuer}");

            double gesamtSteuer = zachaeus.Eintreiben();
            Console.WriteLine($"Mylord, die Gesamteinnahmen in diesem Jahr betragen: {gesamtSteuer}");

            Console.ReadLine();


        }
    }
}
