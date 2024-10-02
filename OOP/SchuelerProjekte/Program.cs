namespace SchuelerProjekte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader schueler = new StreamReader("C:\\Schueler.txt");
            StreamReader projekte = new StreamReader("C:\\Projekte.txt");

            List<string> schuelerListe = new List<string>();
            List<string> projekteListe = new List<string>();

            string schuelerString = schueler.ReadToEnd();
            string projekteString = projekte.ReadToEnd();

            string[] schuelerArray = schuelerString.Split("\n");
            string[] projekteArray = projekteString.Split("\n");

            foreach ( string s in schuelerArray)
            {
                schuelerListe.Add(s);
            }

            foreach (string s in projekteArray)
            {
                projekteListe.Add(s);
            }

            Console.ReadLine();
        }
    }
}
