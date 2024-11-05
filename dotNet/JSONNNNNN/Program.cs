using JSONNNNNN.Models;

namespace JSONNNNNN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirInfo dirInfo = new DirInfo();

            dirInfo.Dateien();


            Console.WriteLine(dirInfo.ToString());
        }
    }
}
