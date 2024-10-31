namespace Dateisuche
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string dateipfad ="";

            string directoryPath = @"C:\Users\ITA5-TN15\OneDrive - IT-Akademie Dr. Heuer GmbH\"; // Pfad zum Verzeichnis
                string fileName = "such.txt"; // Name der gesuchten Datei

                try
                {
                    // Suche nach der Datei im Verzeichnis und in Unterverzeichnissen
                    string[] files = Directory.GetFiles(directoryPath, fileName, SearchOption.AllDirectories);
                
                    if (files.Length > 0)
                    {
                        foreach (var file in files)
                        {
                            Console.WriteLine("Datei gefunden: " + file);
                        dateipfad = file;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Datei nicht gefunden.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fehler: " + ex.Message);
                }

            string userInput = "";
            string userInputAll = "";
            bool check = false;

            while (check == false)
            {
                userInput = Console.ReadLine();
                
                if(userInput == ".")
                {
                    check = true;
                    userInput = "";
                           
                }
                userInputAll += userInput + "\n";
            }
            
            File.AppendAllText(dateipfad, userInputAll + DateTime.Now.ToString());

            Console.WriteLine("Möchten Sie den gesamten Inhalt der Datei sehen? (J/N)");

            string jaodernein = Console.ReadLine();

            switch(jaodernein)
            {
                case "J":
                    Console.WriteLine("Der Inhalt der Datei ist: " + File.ReadAllText(dateipfad));
                    break;
                case "j":
                    Console.WriteLine("Der Inhalt der Datei ist: " + File.ReadAllText(dateipfad));
                    break;
                case "N":
                    break;
                case "n":
                    break;
            }

            
            

            
        }

    }
}

