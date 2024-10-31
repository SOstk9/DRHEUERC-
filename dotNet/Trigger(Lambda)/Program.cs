namespace Trigger_Lambda_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            counter.ZaehlerstandErhoehen(800);

            counter.Bei1000 += counter.On1000;


            counter.ZaehlerstandErhoehen(300);
            counter.ZaehlerstandErhoehen(-300);
            counter.ZaehlerstandErhoehen(+500);
            counter.ZaehlerstandErhoehen(-1000);
            counter.ZaehlerstandErhoehen(300);





        }

    }
}
