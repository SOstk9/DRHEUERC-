namespace Geometrieistsuper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrat quadrat = new Quadrat(2);
            Rechteck rechteck = new Rechteck(2, 4);
            Kreis kreis = new Kreis(2);
            Ellipse ellipse = new Ellipse(2, 4);

            double umfang;
            double flaeche;

            umfang = quadrat.Umfang();
            flaeche = quadrat.Flaeche();
            Console.WriteLine(umfang);
            Console.WriteLine(flaeche);

            umfang = rechteck.Umfang();
            flaeche = rechteck.Flaeche();
            Console.WriteLine(umfang);
            Console.WriteLine(flaeche);

            umfang = kreis.Umfang();
            flaeche = kreis.Flaeche();
            Console.WriteLine(umfang);
            Console.WriteLine(flaeche);

            umfang = ellipse.Umfang();
            flaeche = ellipse.Flaeche();
            Console.WriteLine(umfang);
            Console.WriteLine(flaeche);


            Console.ReadLine();
        }
    }
}
