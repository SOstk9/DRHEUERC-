namespace Logger
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Log loggo = new Log("D:\\Arschloch.txt");

            LogHandler lh = loggo.Schreiben;
            LogHandler lhs = Lesen;

         lhs("D:\\Arschloch.txt");


        }
        static void Lesen(string log)
        {

            Console.WriteLine(File.ReadAllText(log));

        }


    }
}
