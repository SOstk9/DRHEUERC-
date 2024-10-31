namespace Flussman
{
    public class WasserStandEventArgs : EventArgs
    {
        public int _alterWasserStand { get; set; }
        public int _neuerWasserStand { get; set; }

        public WasserStandEventArgs(int alterWasserStand, int neuerWasserstand)
        {
            _alterWasserStand = alterWasserStand;
            _neuerWasserStand = neuerWasserstand;
        }
    }
}