namespace Trigger_Lambda_
{
    public class WasserstandEventArgs : EventArgs
    {
        public int _counter { get; set; }

        public WasserstandEventArgs(int counter)
        {

            _counter = counter;
        }


    }
}