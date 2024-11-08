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

            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\ITA5-TN15\\OneDrive - IT-Akademie Dr. Heuer GmbH\\");
            var moin = dir.EnumerateFiles().OrderByDescending(x => x.Name);
            var größte = dir.EnumerateFiles().OrderByDescending(x => x.Length);

            var letzterZugriff = dir.EnumerateFiles().OrderBy(x => x.LastAccessTime);


            var ersteFünf = numbers.Take(5);
            var letzteFünf = numbers.TakeLast(5);


            var ersteletzte = numbers.Skip(1).SkipLast(3);

            var größerNull = numbers.Select(x => x > 0);

            var nach12 = numbers.SkipWhile(x => x != 12).Skip(1);


            }
    }
}
