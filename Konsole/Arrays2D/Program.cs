using System;

namespace Arrays2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int eingabeLaenge = 6;
            int[] lottoZahl = new int[eingabeLaenge];
            int laengeLottoZahl = lottoZahl.Length;
            int tipp = 0;
            bool zahlDoppelt = false;
            lottoZahl[0] = 1; 

            for (int i = 0; i < laengeLottoZahl; i++)
            {
                
                tipp = rng.Next(1,50);

                for (int j = 0; j < laengeLottoZahl; j++)
                {

                    if (tipp == lottoZahl[j])
                    {
                        i--;
                        zahlDoppelt = true;
                        break;
                    }
                    else
                    {
                        
                        
                    }

                }

            }
            foreach (int i in lottoZahl)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
