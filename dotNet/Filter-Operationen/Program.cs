namespace Filter_Operationen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };

            var kleinersieben = from i in numbers
                                where i < 7
                                select new { i };

            foreach (var i in kleinersieben)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("-----------------------------------------------");
            var geradeZahlen = from i in numbers
                               where i % 2 == 0
                               select new { i };

            foreach (var i in geradeZahlen)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("-----------------------------------------------");

            var einstelligUngerade = from i in numbers
                                     where i % 2 != 0
                                     && i < 10
                                     select new { i };

            foreach (var i in einstelligUngerade)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("------------------------------------------------");

            var sechstesElement = from i in numbers.Skip(6)
                                  where i % 2 != 0
                                  select new { i };

            foreach (var i in sechstesElement)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("------------------------------------------------");

            string[] numbersstring = {"zero", "one", "two", "three", "four", "five", "six","seven", "eight",
"nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };


            var dreiZeichen = from i in numbersstring
                              where i.Length == 3
                              select new { i };

            foreach (var i in dreiZeichen)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("------------------------------------------------");



            var oo = from i in numbersstring
                     where i.Contains("o")
                     select new { i };

            foreach (var i in oo)
            { Console.WriteLine(i.ToString()); }

            Console.WriteLine("-----------------------------------------------");

            var teen = from i in numbersstring
                       where i.EndsWith("teen")
                       select new { i };

            foreach (var i in teen)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("-----------------------------------------------");

            var teenbig = from i in numbersstring
                          where i.EndsWith("teen")
                          select i.ToUpper();
            foreach(var i in teen)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("-----------------------------------------------");

            var fourDrin = from i in numbersstring
                           where i.Contains("four")
                           select new { i };

            foreach(var i in fourDrin)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("-----------------------------------------------");


            var summeAllerWerte = numbers.Sum();

            Console.WriteLine(numbers.Sum());


            Console.WriteLine("-----------------------------------------------");

            var kleinsteZahl = numbers.Min();

            Console.WriteLine(numbers.Min());

            Console.WriteLine("-----------------------------------------------");

            var groeßteZahl = numbers.Max();
            Console.WriteLine(numbers.Max());

            Console.WriteLine("-----------------------------------------------");

            var durchschnitt = numbers.Average();
            Console.WriteLine(numbers.Average());

            Console.WriteLine("-----------------------------------------------");

            var durchschnittungerade = from i in numbers
                                       where i % 2 == 0
                                       select new { i };
           

            Console.WriteLine(durchschnittungerade.Min().ToString());

            Console.WriteLine("-----------------------------------------------");




        }
    }
}
