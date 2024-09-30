namespace Filliale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filliale kundk = new Filliale("kundk", 20, 1200.40);
            Filliale globus = new Filliale("globus", 0, 10.0);


           kundk.Information();
           globus.Information();
           globus.Einkauf();
           kundk.Einkauf();
           kundk.Information();
           globus.Information();
           kundk.Verkauf();
           globus.Verkauf();

           Console.ReadLine();
        }
    }
}
