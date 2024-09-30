using System;

namespace struktur2
{
    internal class Program
    {
        struct Bruch
        {
            public int zaehler;
            public int nenner;
        }
        static void Main(string[] args)
        {
            Bruch bruch1 = new Bruch();
            bruch1.zaehler = int.Parse(Console.ReadLine());
            bruch1.nenner = int.Parse(Console.ReadLine());
            Bruch bruch2 = new Bruch();
            bruch2.zaehler = int.Parse(Console.ReadLine());
            bruch2.nenner = int.Parse(Console.ReadLine());




            AusgabeBruch(bruch1.zaehler, bruch1.nenner);
            AusgabeBruch(bruch2.zaehler, bruch2.nenner);

            BruchZuDouble(bruch1.zaehler, bruch1.nenner);
            BruchZuDouble(bruch2.zaehler, bruch2.nenner);

            AddBruch(bruch1.zaehler, bruch1.nenner, bruch2.zaehler, bruch2.nenner);
            SubBruch (bruch1.zaehler, bruch1.nenner, bruch2.zaehler, bruch2.nenner);
            MulBruch(bruch1.zaehler, bruch1.nenner, bruch2.zaehler, bruch2.nenner);
            DivBruch(bruch1.zaehler, bruch1.nenner, bruch2.zaehler, bruch2.nenner);



            Console.ReadLine();

        }

        static void AusgabeBruch(int zaehler, int nenner)
        {
            Console.WriteLine(zaehler + "/" + nenner);

        }
        static void BruchZuDouble(int zaehler, int nenner)
        {
            double rueckgabe = (Convert.ToDouble(zaehler) / Convert.ToDouble(nenner));
            Console.WriteLine("Kommazahl: {0}", rueckgabe);
        }
        static void AddBruch(int bruch1Zaehler, int bruch1Nenner, int bruch2Zaehler, int bruch2Nenner)
        {

            int zaehlerErgebnis;
            int nennerErgebnis;

            int zaehlerErgebnis1;
            int nennerErgebnis1;

            if (bruch1Nenner == bruch2Nenner)
            {
                zaehlerErgebnis = bruch1Zaehler + bruch2Zaehler;
                nennerErgebnis = bruch1Nenner;
               zaehlerErgebnis = zaehlerErgebnis / KuerzeBruch(zaehlerErgebnis, nennerErgebnis);
                nennerErgebnis = nennerErgebnis / KuerzeBruch(zaehlerErgebnis, nennerErgebnis);
            }
            else
            {

                zaehlerErgebnis = bruch1Zaehler * bruch2Nenner;
                nennerErgebnis = bruch1Nenner * bruch2Nenner;

                zaehlerErgebnis1 = bruch2Zaehler * bruch1Nenner;
                nennerErgebnis1 = bruch2Nenner * bruch1Nenner;

                zaehlerErgebnis = zaehlerErgebnis + zaehlerErgebnis1;
                nennerErgebnis = nennerErgebnis + zaehlerErgebnis1;

                zaehlerErgebnis = zaehlerErgebnis / KuerzeBruch(zaehlerErgebnis, nennerErgebnis);
                nennerErgebnis = nennerErgebnis / KuerzeBruch(zaehlerErgebnis, nennerErgebnis);
                //KuerzeBruch(ref zaehlerErgebnis, ref nennerErgebnis);
            }
            Console.WriteLine("Addition ist: {0} / {1}", zaehlerErgebnis, nennerErgebnis);
        }
        static void SubBruch(int bruch1Zaehler, int bruch1Nenner, int bruch2Zaehler, int bruch2Nenner)
        {
            int zaehlerErgebnis;
            int nennerErgebnis;

            int zaehlerErgebnis1;
            int nennerErgebnis1;


            if (bruch1Nenner == bruch2Nenner)
            {
                zaehlerErgebnis = bruch1Zaehler - bruch2Zaehler;
                nennerErgebnis = bruch1Nenner;
                zaehlerErgebnis = zaehlerErgebnis / KuerzeBruch(zaehlerErgebnis, nennerErgebnis);
                nennerErgebnis = nennerErgebnis / KuerzeBruch(zaehlerErgebnis, nennerErgebnis);
                //KuerzeBruch(ref zaehlerErgebnis, ref nennerErgebnis);
            }
            else
            {
                zaehlerErgebnis = bruch1Zaehler * bruch2Nenner;
                nennerErgebnis = bruch1Nenner * bruch2Nenner;

                zaehlerErgebnis1 = bruch2Zaehler * bruch1Nenner;
                nennerErgebnis1 = bruch2Nenner * bruch1Nenner;

                zaehlerErgebnis = zaehlerErgebnis - zaehlerErgebnis1;
                nennerErgebnis = nennerErgebnis - zaehlerErgebnis1;


                zaehlerErgebnis = zaehlerErgebnis / KuerzeBruch(zaehlerErgebnis, nennerErgebnis);
                nennerErgebnis = nennerErgebnis / KuerzeBruch(zaehlerErgebnis, nennerErgebnis);
                //KuerzeBruch(ref zaehlerErgebnis, ref nennerErgebnis);
            }
            Console.WriteLine("Subtraktion ist: {0} / {1}", zaehlerErgebnis, nennerErgebnis );

        }
        static void MulBruch(int bruch1Zaehler, int bruch1Nenner, int bruch2Zaehler, int bruch2Nenner)
        {
            int zaehlerErgebnis;
            int nennerErgebnis;

            zaehlerErgebnis = bruch1Zaehler * bruch2Zaehler;
            nennerErgebnis = bruch1Nenner * bruch2Nenner;


            zaehlerErgebnis = zaehlerErgebnis / KuerzeBruch(zaehlerErgebnis, nennerErgebnis);
            nennerErgebnis = nennerErgebnis / KuerzeBruch(zaehlerErgebnis, nennerErgebnis);
            //KuerzeBruch(ref zaehlerErgebnis, ref nennerErgebnis);

            Console.WriteLine("Multiplikation ist: {0} / {1}", zaehlerErgebnis, nennerErgebnis);
        }
        static void DivBruch(int bruch1Zaehler, int bruch1Nenner, int bruch2Zaehler, int bruch2Nenner)
        {
            int zaehlerErgebnis;
            int nennerErgebnis;
            UmkehrBruch(ref bruch2Zaehler, ref bruch2Nenner);


            zaehlerErgebnis = bruch1Zaehler * bruch2Zaehler;
            nennerErgebnis = bruch1Nenner * bruch2Nenner;

            zaehlerErgebnis = zaehlerErgebnis / KuerzeBruch(zaehlerErgebnis, nennerErgebnis);
            nennerErgebnis = nennerErgebnis / KuerzeBruch(zaehlerErgebnis, nennerErgebnis);
            //KuerzeBruch(ref zaehlerErgebnis, ref nennerErgebnis);

            Console.WriteLine("Division ist: {0} / {1}", zaehlerErgebnis, nennerErgebnis);
        }
        static void UmkehrBruch(ref int zaehler, ref int nenner)
        {
            int temp = zaehler;
            zaehler = nenner;
            nenner = temp;

        }
        static int KuerzeBruch(int zaehler, int nenner)
        {
            if (nenner > 0)

            {
                int rest;
                rest = zaehler % nenner;
                zaehler = nenner;
                nenner = rest;
                return KuerzeBruch(zaehler, nenner);
            }
            else
            {
                return zaehler;
            };
        }


    }
}
