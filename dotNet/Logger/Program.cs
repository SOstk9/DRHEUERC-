namespace Logger
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Log loggo = new Log("D:\\Arschloch.txt");

            LogHandler lh = Log.Schreiben;
            LogHandler lhs = Lesen;
            
         lh("hallo");
         lhs("D:\\Arschloch.txt");


        }
        static void Lesen(string log)
        {

            Console.WriteLine(File.ReadAllText(log));

        }


    }
}
