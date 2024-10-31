namespace Warpkern
{
    public class WarpkernEventArgs
    {
        public double _oldTemperature { get; set; }
        public double _newTemperature { get; set; }

        public WarpkernEventArgs(double oldTemperature, double newTemperature)
        {
            _oldTemperature = oldTemperature;
            _newTemperature = newTemperature;
        }
    }
}