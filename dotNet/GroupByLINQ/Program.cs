using System.Diagnostics;

namespace GroupByLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Aufgabe1();
            Aufgabe2();




        }
        static void Aufgabe1()
        {
            string[] numbers =
{ "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
"nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };

            var anfang = numbers.GroupBy(x => x[0]);
            foreach (IGrouping<char, string> gruppe in anfang)
            {
                Console.WriteLine("Anfangsbuchstabe:" + gruppe.Key);

                foreach (string wort in gruppe)
                {
                    Console.WriteLine(wort);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------");

            var laenge = numbers.GroupBy(x => x.Length);
            foreach (IGrouping<int, string> gruppe in laenge)
            {
                Console.WriteLine($"Gruppe: {gruppe.Key}");

                foreach (string wort in gruppe)
                {
                    Console.WriteLine(wort);
                }


            }

            Console.WriteLine("---------------------------------------------------------------------");

            var anfanglaenge = numbers
                                        .GroupBy(x => x[0]);

            foreach (var anfangsbs in anfanglaenge)
            {
                Console.WriteLine($"Anfangsbuchstabe: {anfangsbs.Key}");

                foreach (var laengebs in anfangsbs.GroupBy(x => x.Length))
                {
                    Console.WriteLine($"Laenge: {laengebs.Key}");

                    foreach (var laenggg in laengebs)
                    {
                        Console.WriteLine(laenggg);
                    }
                }
            }





        }
        static void Aufgabe2()
        {

            var alle = Process.GetProcesses().Select(x =>
           {
               int tmp = 0;
               try
               {
                   tmp = x.Modules.Count;
               }
               catch (System.ComponentModel.Win32Exception)
               {
               }
               return new { Process = x, ModuleCount = tmp };
           });
           
           


            Console.WriteLine("--------------------------------Threads-------------------------------------");

            var anzahlThreads = alle.GroupBy(alle => alle);

            foreach (var process in anzahlThreads)
            {
                Console.WriteLine($"Gruppe:{process.Key}");

                foreach (var thread in process.GroupBy(x => x.Process.Threads.Count))
                {
                    Console.WriteLine($"Threads: {thread.Key}");
                }

            }

            Console.WriteLine("-------------------------------Module--------------------------------------");

            var anzahlModule = alle.GroupBy(x => x);

            try
            {
                foreach (var prozesse in anzahlModule)
                {
                    Console.WriteLine($"Prozesse:{prozesse.Key}");

                    foreach (var module in prozesse.GroupBy(x => x.Process.Modules.Count))
                    {
                        Console.WriteLine($"Module: {module.Key }");
                    }
                }
            }
            catch
            {

            }
        }


    }
}
