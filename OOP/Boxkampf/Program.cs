namespace Boxkampf
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Boxer uwe = new Boxer("Uwe",10);
            Boxer fred = new Boxer("Fred",10);

            int player1Vitalitaet = uwe.GetVitalitaet();
            int player2Vitalitaet = fred.GetVitalitaet();
            string gewinner = "";

            while (uwe.GetVitalitaet() != 0 && fred.GetVitalitaet() != 0)
            {
                if (uwe.GetVitalitaet() == 0 || fred.GetVitalitaet() == 0)
                { break; }
                else
                {
                    uwe.Schlagen();
                    fred.Schlagen();
                    player1Vitalitaet = uwe.GetVitalitaet();
                    player2Vitalitaet = fred.GetVitalitaet();
                    Console.WriteLine(player1Vitalitaet);
                    Console.WriteLine(player2Vitalitaet);
                    Console.ReadLine();
                }
            }
            if (uwe.GetVitalitaet() == 0)
            {
                gewinner = uwe.GetName();
            }
            else
            {
                gewinner = fred.GetName();
            }
            Console.WriteLine($"Der Gewinner ist: {gewinner}");
        }
    }
}
