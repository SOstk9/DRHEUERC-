using SkiaSharp;
using static System.Net.Mime.MediaTypeNames;

namespace ThreadsExceptiomnns
   
{
    internal class Program
    {
        public static int counter = 0;
        static void Main(string[] args)
        {
           
            SKBitmap bitmap = new SKBitmap();

            FileSystemWatcher watcher = new FileSystemWatcher(@"C:\Tesst");

            watcher.EnableRaisingEvents = true;

            Task.Run(() =>
            {
                watcher.Created += new FileSystemEventHandler(ColorToGray);
                watcher.Created += new FileSystemEventHandler(Decode);
            });



            Console.ReadLine();
        }






        static void ColorToGray(object sender, FileSystemEventArgs path)
        {
           
            SKBitmap image  = SKBitmap.Decode(path.FullPath);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    SKColor color = image.GetPixel(x, y);
                    byte gray = (byte)(0.2126f * color.Red + 0.7152f * color.Green + 0.0722f *
                   color.Blue);
                    SKColor sKColor = new SKColor(gray, gray, gray, color.Alpha);
                    image.SetPixel(x, y, sKColor);
                }
            }
            try
            {
                using (FileStream grayFileStream = File.Create($@"C:\Tesst\schwatt\{counter}{path.Name}"))
                {
                    image.Encode(grayFileStream, SKEncodedImageFormat.Jpeg, 100);
                }
                counter++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            image.Dispose();
        }

        static void Decode(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File Created:{e.FullPath}");
        }
    }
}
