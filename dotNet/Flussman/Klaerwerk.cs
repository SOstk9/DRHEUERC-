namespace Flussman
{
    public class Klaerwerk
    {
        private string _name;

        public Klaerwerk(string name)
        {
            _name = name;
        }

        public void ReagiereEinleitungstoppen(object klaerwerk, WasserStandEventArgs e)
        {
            if (e._neuerWasserStand < 3000 && e._neuerWasserStand > 800)
            {
                Console.WriteLine($"Einleitung stoppen, {klaerwerk}");
            }
            else
            {
                Console.WriteLine($"Einleiten, {klaerwerk}");
            }
        }
    }
}