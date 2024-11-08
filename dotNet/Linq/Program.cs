namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = File.ReadAllText(@"C:\Users\ITA5-TN15\OneDrive - IT-Akademie Dr. Heuer GmbH\Programmieren\Produkte.txt");
            string[] stringarray;
            string[] stringarraysemicolon = null;
            List<Produkt> liste = new List<Produkt>();
            Console.WriteLine(file);

           stringarray = file.Split("\n");
           

           
            for(int i = 0; i < stringarray.Length; i++)
            {
                stringarray[i] = stringarray[i].Replace("\r", null);
                stringarray[i] = stringarray[i].Replace(" ", null);
                stringarray[i] = stringarray[i].Replace(",", ".");
                stringarraysemicolon = stringarray[i].Split(";");
                Produkt produkt = new Produkt(stringarraysemicolon[0], Convert.ToDouble(stringarraysemicolon[1]), stringarraysemicolon[2]);     
                liste.Add(produkt);
            }

           //foreach (string s in stringarray)
           //{
            

           // }

           

            Console.WriteLine("--------------------------------------------------------------------");
            var kategorie = liste.GroupBy(x => x._kategorie);

                foreach (var item in kategorie)
            {
                Console.WriteLine("Kategorie:"+ item.Key);

                foreach(var preis in item)
                {
                    
              
                }
                Console.WriteLine(item.Average(x => Convert.ToDouble(x._preis)));
            }

                




        }
    }
}
