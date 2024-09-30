using System;
using System.Diagnostics;
using System.Threading;

namespace SchereSteinPapier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe;
            int eingabeZahl = 0;
            bool cont = false;
            bool exit = false;

            int countuser = 0;
            int countgegner = 0;
            int countdraw = 0;

            bool falscheEingabe = true;


            while (exit == false)
            {
                Console.WriteLine("Schere, Stein, oder Papier?");
                eingabe = Console.ReadLine();

                Random rnd = new Random();
                int gegner = rnd.Next(3);





                switch (eingabe)
                {
                    case "Schere":
                        eingabeZahl = 0;
                        cont = false;
                        break;
                    case "schere":
                        eingabeZahl = 0;
                        cont = false;
                        break;

                    case "Stein":
                        eingabeZahl = 1;
                        cont = false;
                        break;
                    case "stein":
                        eingabeZahl = 1;
                        cont = false;
                        break;
                    case "Papier":
                        eingabeZahl = 2;
                        cont = false;
                        break;
                    case "papier":
                        eingabeZahl = 2;
                        cont = false;
                        break;
                    default:
                        Console.WriteLine("Bitte Schere, Stein, oder Papier eingeben!");
                        cont = true;

                        break;
                }
                if (cont == false)
                {

                    switch (gegner)
                    {
                        case 0:
                            Console.WriteLine("Der Gegner hat Schere");
                            break;


                        case 1:
                            Console.WriteLine("Der Gegner hat Stein");
                            break;

                        case 2:
                            Console.WriteLine("Der Gegner hat Papier");
                            break;

                        default:
                            break;
                    }

                    if (gegner == eingabeZahl)
                    {
                        Console.WriteLine("Unentschieden!\n");
                        countdraw++;
                    }
                    if ((gegner == 0 && eingabeZahl == 1) || (gegner == 1 && eingabeZahl == 2) || (gegner == 2 && eingabeZahl == 0))
                    {
                        Console.WriteLine("Du gewinnst!\n");
                        countuser++;
                    }
                    if ((gegner == 1 && eingabeZahl == 0) || (gegner == 2 && eingabeZahl == 1) || (gegner == 0 && eingabeZahl == 2))
                    {
                        Console.WriteLine("Du verlierst!\n");
                        countgegner++;
                    }

                    falscheEingabe = true;
                    while (falscheEingabe == true)
                    {
                        Console.WriteLine("AKTUELLER SPIELSTAND:\n User: {0}\tGegner: {1}\tUnentschieden: {2}\n", countuser, countgegner, countdraw);
                   
                        Console.WriteLine("Möchtest du noch einmal spielen? (1 = Ja / 2 = Nein)");
                       
                        int replay = int.Parse(Console.ReadLine());
                        if(replay)
                        if (replay == 2)
                        {
                            exit = true;
                            falscheEingabe = false;
                        }
                        else if (replay == 1)
                        {
                            falscheEingabe = false;
                            Console.Clear();

                        }
                        else
                        {
                            
                           
                            Console.SetCursorPosition(0, 9); 
                            Console.WriteLine("                                                     ");
                            Console.WriteLine("                                                     ");
                            Console.SetCursorPosition(0, 9);
                            Console.WriteLine("Falsche Eingabe!!!");
                            Thread.Sleep(500);
                            Console.SetCursorPosition(0, 9);
                            Console.WriteLine("                                                     ");
                            Console.WriteLine("                                                     ");
                            Console.SetCursorPosition(0, 5);

                            falscheEingabe = true;
                           
                        }
                    }
                }
            }
            // Console.ReadLine();
        }
    }
}
