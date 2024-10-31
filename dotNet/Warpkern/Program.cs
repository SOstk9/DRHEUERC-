namespace Warpkern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warpkern ultra = new Warpkern("Ultra", 200);

            WarpKernKonsole headmaster = new WarpKernKonsole("Headmaster");

            ultra.TemperaturAenderung += headmaster.ReagiereAufTemperatur;

            ultra.WarpkernTemperatur = 510;

        }
    }
}
