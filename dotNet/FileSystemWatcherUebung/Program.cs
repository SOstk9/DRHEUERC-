using System.Net;

namespace FileSystemWatcherUebung
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            FileSystemWatcher lookup = new FileSystemWatcher("D:\\Lookup");

            lookup.Filter = "*.lookup";
            lookup.EnableRaisingEvents = true;
            lookup.Created += OnFileCreated;

        Console.ReadLine();

        }

        public static void OnFileCreated(object sender, FileSystemEventArgs e)
        {
            string path = e.FullPath;
            int counter = 0;
            Console.WriteLine(path);
            string dateiname = e.Name;
            dateiname.Replace(".lookup", "");
            string neueDatei = $"D:\\Lookup\\{dateiname}.resolve";
            string ipAdress = "";
            IPAddress[] address = null;

            File.ReadAllLines(path);


            foreach(string line in File.ReadAllLines(path))
            {
                address = Dns.GetHostAddresses(line);
                

                foreach (IPAddress ip in address)
                {
                    ipAdress += ip +"\n";
                   
                }
                
            }

            
            CreateDNSFile(neueDatei, ipAdress);
            counter++;
    

        }
        public static void CreateDNSFile(string path, string ips)
        {
            File.AppendAllText(path, ips);
        }

    
    }
}
