namespace Trigger_Lambda_
{
    internal class Counter
    {
        public int _counter;

        public int CounterSetzen
        {
            get;set; 
        }

        public EventHandler<WasserstandEventArgs> Bei1000;
        public void ZaehlerstandErhoehen(int x)
        {
            _counter += x;

            if (_counter >= 1000)
            {
                Bei1000?.Invoke(this, new WasserstandEventArgs(_counter));
                Console.WriteLine("Zählerstand erreicht");
            }
        }

        public void Clear()
        {
            _counter = 0;
        }

        public void On1000(object sender, WasserstandEventArgs e)
        {
            if (e._counter >= 1000)
            {
                Console.WriteLine("Herzlichen Glühstrumpf, sie sind unser 1000ster Kunde");
            }
        }


    }
}
