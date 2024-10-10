namespace Widerstaende
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Widerstand R1 = new Widerstand("R1", 100);
            Widerstand R2 = new Widerstand("R2", 200);
            Widerstand R3 = new Widerstand("R3", 300);
            Widerstand R4 = new Widerstand("R4", 400);
            Widerstand R5 = new Widerstand("R5", 500);
            Widerstand R6 = new Widerstand("R6", 600);
            Parallelschaltung R1R3 = new Parallelschaltung(R1, R3);
            Console.WriteLine($"Der Widerstand {R1R3.GetName()} beträgt: {R1R3.GetWiderstand()}");
            Reihenschaltung R13R2 = new Reihenschaltung(R1R3, R2);
            Console.WriteLine($"Der Widerstand {R13R2.GetName()} beträgt: {R13R2.GetWiderstand()}");
            Reihenschaltung R4R5 = new Reihenschaltung(R4, R5);
            Console.WriteLine($"Der Widerstand {R4R5.GetName()} beträgt: {R4R5.GetWiderstand()}");
            Parallelschaltung gesamt = new Parallelschaltung(R13R2, R4R5, R6);
            Console.WriteLine($"Der Gesamtwiderstand beträgt: {gesamt.GetWiderstand()}");

            Console.ReadLine();

        }
    }
}
