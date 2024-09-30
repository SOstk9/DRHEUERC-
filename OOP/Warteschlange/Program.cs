namespace Warteschlange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedQueue hallo = new MyLinkedQueue();

            hallo.Enqueue("Hannes");
            Console.ReadLine();
            hallo.Enqueue("Dieter");
            hallo.Print();
            Console.ReadLine();
            hallo.Enqueue("Hodor");
            hallo.Print();
            Console.ReadLine();
        }
    }
}
