using Adresse.Models;


namespace Adresse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person eins = new Person("mister", "uwe", 76);
            Hund pluto = new Hund("pluto");
            eins.SetAddress("Holzweg", "69", "48607", "Ochtrup");



            eins.GibPersonAus();
            eins.SetAddress("Obermaierweg", "14", "44803", "Bochum-Gerthe");
            eins.GibPersonAus();
            eins.SetHund(pluto);
            
            string info = pluto.HundInfo();
            Console.WriteLine(info);
            Console.ReadLine();
            Console.WriteLine("Du Affe!");
            eins.GetHund().Fuettern();
            info = pluto.HundInfo();
            Console.WriteLine(info);
            bool gassi = pluto.GassiGehen(eins);
            Console.WriteLine(gassi);
         

            Console.ReadLine();
        }
    }
}
