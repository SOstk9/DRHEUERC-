namespace Prüfsumme.Models
{
    internal class Pruefsumme
    {
        private [] _identifikationsnummer;

        public Pruefsumme(int[] identifikationsnummer)
        {
            _identifikationsnummer = identifikationsnummer;
        }

        public bool Check(int summe)
        {
            summe = Addieren(Mastercheck3000());
            bool pruefung;

            if (summe % 10 == 0)
            {
                pruefung = true;
            }
            else
            {
                pruefung = false;
            }

            return pruefung;

        }

        public int[] Mastercheck3000(int[] nummer)
        {
            for (int i = 0; i < nummer.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Quersumme(nummer[i]);
                }
            }
            return nummer;
        }




        public int Addieren(int[] nummer)
        {
            int a = 0;
            Mastercheck3000(nummer);

            for (int i = 0; i < nummer.Length; i++)
            {
                
                a = a + nummer[i];
            }
            return a;
        }

        public int Verdoppelt(int zahl)
        {

            zahl = zahl * 2;


            return zahl;
        }



        public int Quersumme(int nummer)
        {
            Verdoppelt(nummer);
           nummer =  nummer * 2 - 9;
            return nummer;

        }

    }
}

