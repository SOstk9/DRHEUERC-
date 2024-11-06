namespace LINQQQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };

            string[] numberss =   { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
                                    "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };


            var mama = numbers.OrderBy(x => x);
            var uhuhuu = numbers.OrderByDescending(x => x);

            var idontwannadie = from i in mama
                                where i % 2 == 0
                                select i;




            var isometimeswish = numberss.OrderBy(x => numberss.Length);

            var iveneverbeenborn = numberss.OrderByDescending(x => numberss.Length).ThenByDescending(x=>x);

            var atall = numberss.Reverse();

            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\ITA5 - TN15\\OneDrive - IT - Akademie Dr.Heuer GmbH\\");
            Console.WriteLine(dir.EnumerateFiles());



            }
    }
}
