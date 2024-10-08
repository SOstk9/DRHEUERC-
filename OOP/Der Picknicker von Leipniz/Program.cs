using System.Xml.Schema;

namespace Der_Picknicker_von_Leipniz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto ford = new Auto(true);
            Auto neu = new Auto(false,"ST-SO-1910");
            Auto herbie = new Auto(false, "AH-EU-1900")
            Pickup pickup = new Pickup(false);

            ford.AntenneAusfahren();
            Console.WriteLine(ford.IstAntenneDraußen());
            Console.ReadLine();


        }
    }
}
