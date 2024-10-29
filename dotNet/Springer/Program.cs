namespace Springer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Spielbrett spielbrett = new Spielbrett();

           Springer springer = new Springer(2, 4);

            spielbrett.SpielfeldAusgabe();

            spielbrett.PlaceFigur(springer);

            Console.WriteLine("--------------------------------");

            spielbrett.SpielfeldAusgabe();

            Console.ReadLine();
        }
    }
}
