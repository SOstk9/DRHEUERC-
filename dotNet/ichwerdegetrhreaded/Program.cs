namespace ichwerdegetrhreaded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(() =>
            {
                {
                    Console.WriteLine("Welche Datei auslesen? Task1");
                    string eingabe = Console.ReadLine();
                    string text = DateiAuslesen(eingabe + ".txt");


                    Dictionary<char, int> dict = BuchstabenZaehlen(text);

                    Console.WriteLine(DictionaryAuslesen(dict));

                    File.WriteAllText($"{eingabe}.freq", DictionaryAuslesen(dict));
                }
            });
            Task task2 = new Task(() =>
            {
                {
                    Console.WriteLine("Welche Datei auslesen? Task2");
                    string eingabe = Console.ReadLine();
                    string text = DateiAuslesen(eingabe + ".txt");


                    Dictionary<char, int> dict = BuchstabenZaehlen(text);

                    Console.WriteLine(DictionaryAuslesen(dict));

                    File.WriteAllText($"{eingabe}.freq", DictionaryAuslesen(dict));
                }
            });
            Task task3 = new Task(() =>
            {
                {
                    Console.WriteLine("Welche Datei auslesen? Task3");
                    string eingabe = Console.ReadLine();
                    string text = DateiAuslesen(eingabe + ".txt");


                    Dictionary<char, int> dict = BuchstabenZaehlen(text);

                    Console.WriteLine(DictionaryAuslesen(dict));

                    File.WriteAllText($"{eingabe}.freq", DictionaryAuslesen(dict));
                }
            });


            task.RunSynchronously();
            task2.RunSynchronously();
            task3.RunSynchronously();
            

      
        }

        static string DateiAuslesen(string pfad)
        {
            string text = File.ReadAllText(pfad);
            return text;
          
        }

        static Dictionary<char,int> BuchstabenZaehlen(string pfad)
        {

            Dictionary<char, int> dict = new Dictionary<char, int>();

            pfad = pfad.Replace(",", null);
            pfad = pfad.Replace(" ", null);
            pfad = pfad.Replace(".", null);
            
            foreach (char key in pfad)
            {
                if (dict.ContainsKey(key))
                {
                    dict[key]++;
                }
                else
                {
                    dict.Add(key, 0);
                }
                
            }
            return dict;
        }

        static string DictionaryAuslesen(Dictionary<char, int> dict)
        {
            string dictionary = "";
            var sortieren = dict.OrderBy(x => x.Key);
            foreach (var item in sortieren)
            {
                dictionary += item.Key + " " + item.Value + "\n";

            }
            
            
            return dictionary;
        }
    }
}
