namespace PiggyBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PiggyBank sparschwein = new PiggyBank(50);
            sparschwein.Shake();
            int ueberlauf =  sparschwein.Add10Cents(51);
            Console.WriteLine(ueberlauf);
            sparschwein.Shake();
           

            sparschwein.Add1Euro(3);
            sparschwein.Add1Cents(20);
            double geldBetrag = sparschwein.BreakInto();
            sparschwein.Shake();
            Console.WriteLine(geldBetrag);
            Console.ReadLine();
        }
        
    }
}
