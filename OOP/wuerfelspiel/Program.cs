namespace wuerfelspiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spielstandPlayer1;
            int spielstandPlayer2;
            string gewinner;

            Player player1 = new Player("p1");
            Player player2 = new Player("p2");

            player1.Gamble();
            player2.Gamble();
            spielstandPlayer1 = player1.GetScore();
            spielstandPlayer2 = player2.GetScore();

            if (spielstandPlayer1 > spielstandPlayer2)
            {
                gewinner = player1.GetName();
             
            }
            else
            {
                gewinner = player2.GetName();
            }
            Console.WriteLine(player1.GetScore());
            Console.WriteLine(player2.GetScore());


            Console.WriteLine($"{gewinner} gewinnt");
            Console.ReadLine();
        }
    }
}
