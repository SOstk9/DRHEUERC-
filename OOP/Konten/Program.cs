namespace Konten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Girokonto girohiro = new Girokonto("Standard", 1, 0, 0);
            Festgeldkonto festgeld = new Festgeldkonto(4, DateTime.Today, 2, 0, 2);
            Sparkonto sparfuchs = new Sparkonto(3, 0,0.5);
            Person ullrich = new Person("Mermann", "Ullrich", girohiro);

            Console.WriteLine(girohiro.Kontostand());
            Console.WriteLine(girohiro.Zinsen());
            Console.ReadLine();

            girohiro.Einzahlen(1000);
            Console.WriteLine(girohiro.Kontostand());
            Console.ReadLine();

            Console.WriteLine(festgeld.Kontostand());
            festgeld.RestLaufzeit();
            Console.ReadLine();

            Console.WriteLine(sparfuchs.Kontostand());
            sparfuchs.Einzahlen(200);
            Console.ReadLine();
            sparfuchs.Zinsen();
            Console.ReadLine();
            


        }


    }
}
