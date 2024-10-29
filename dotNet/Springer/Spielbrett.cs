namespace Springer
{
    internal class Spielbrett
    {
        public static int[,] spielbrett = new int[8, 8];
        Springer springer;
        List<int[]> moeglichkeiten = new List<int[]>();
        public static int counter = 0;

        public Spielbrett()
        {
            moeglichkeiten.Add(new int[] { +1, +2 });
            moeglichkeiten.Add(new int[] { +2, +1 });
            moeglichkeiten.Add(new int[] { +2, -1 });
            moeglichkeiten.Add(new int[] { +1, -2 });
            moeglichkeiten.Add(new int[] { -1, -2 });
            moeglichkeiten.Add(new int[] { -2, -1 });
            moeglichkeiten.Add(new int[] { -2, +1 });
            moeglichkeiten.Add(new int[] { -1, +2 });
        }

        public void PlaceFigur(Springer springer)
        {
            spielbrett[springer.x, springer.y] = 1;
        }
        public void SpielfeldAusgabe()
        {
            for (int i = 0; i < spielbrett.GetLength(0); i++)
            {
                for (int j = 0; j < spielbrett.GetLength(1); j++)
                {
                    Console.Write(spielbrett[i, j] + "\t");
                }
                Console.WriteLine("\n");

            }

        }

        public void Move()
        {

            while (counter <= 64)
            {
                if (springer.x - 2 >= 0 || springer.y - 2 >= 0 || springer.x + 2 >= 8 || springer.y + 2 >= 8)
                {
                    

                    if (moeglichkeiten[0] == nächsteMöglichkeit)
                    {
                        springer.x = springer.x + moeglichkeiten[0][0];
                        springer.y = springer.y + moeglichkeiten[0][1];
                    }

                    else if (moeglichkeiten[0] == nächsteMöglichkeit)
                    {
                        springer.x = springer.x + moeglichkeiten[1][0];
                        springer.y = springer.y + moeglichkeiten[1][1];
                    }
                    else if (moeglichkeiten[0] == nächsteMöglichkeit)
                    {
                        springer.x = springer.x + moeglichkeiten[2][0];
                        springer.y = springer.y + moeglichkeiten[2][1];
                    }
                    else if (moeglichkeiten[0] == nächsteMöglichkeit)
                    {
                        springer.x = springer.x + moeglichkeiten[3][0];
                        springer.y = springer.y + moeglichkeiten[3][1];
                    }
                    else if (moeglichkeiten[0] == nächsteMöglichkeit)
                    {
                        springer.x = springer.x + moeglichkeiten[4][0];
                        springer.y = springer.y + moeglichkeiten[4][1];
                    }
                    else if (moeglichkeiten[0] == nächsteMöglichkeit)
                    {
                        springer.x = springer.x + moeglichkeiten[5][0];
                        springer.y = springer.y + moeglichkeiten[5][1];
                    }
                    else if (moeglichkeiten[0] == nächsteMöglichkeit)
                    {
                        springer.x = springer.x + moeglichkeiten[6][0];
                        springer.y = springer.y + moeglichkeiten[6][1];
                    }
                    else if (moeglichkeiten[0] == nächsteMöglichkeit)
                    {
                        springer.x = springer.x + moeglichkeiten[7][0];
                        springer.y = springer.y + moeglichkeiten[7][1];
                    }

                    }
                    
                if (spielbrett[springer.x, springer.y] < 1)
                {
                    counter++;
                    spielbrett[springer.x, springer.y] = counter;

                }
               
            }
        }

        public bool NaechsteMoeglichkeit()
        {
            //Das, wo es am wenigsten Folgemöglichkeiten gibt


            return true;
        }
        
    }
}
