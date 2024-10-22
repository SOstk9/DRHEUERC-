using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Froschkoenig
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int zaehler = 0;
            StreamReader reader = new StreamReader("X:\\ITA5\\Unterlagen\\dotNet\\02 - RegEx\\Froschkönig Unix Zeilenumbrüche.txt");



            string line;
            while ((line = reader.ReadLine()) != null)
            {
                zaehler++;
                if (IsUmlaut(line) == true)
                {
                    Console.WriteLine($"Umlaut gefunden in Zeile {zaehler}");
                }
                if (IsDer(line) == true)
                {
                    Console.WriteLine($"Der gefunden in Zeile {zaehler}");
                }
                if (IsGroßbuchstabe(line)== true)
                {
                    Console.WriteLine($"Zeile {zaehler} beginnt mit einem Großbuchstaben");
                }
                if (IsFroschkönig(line)==true)
                {
                    Console.WriteLine($"Zeile {zaehler} enthält das Wort Frosch oder Froschkönig");
                }
                if (IsPunkt(line)==true)
                {
                    Console.WriteLine($"In Zeile {zaehler} ist ein Punkt am Ende.");
                }
                if (SharpSEndWord(line)==true)
                {
                    Console.WriteLine($"In Zeile {zaehler} ist ein hottes s");
                }
                if (IsWhitespace(line) == true)
                {
                    Console.WriteLine($"{zaehler} ist ein Zeilenumbruch");
                }
                if (IsThreeLetters(line)==true)
                {
                    Console.WriteLine($"In Zeile {zaehler} ist mindestens ein Wort mit drei Buchstaben ");
                }
                if(IsArtikel(line) == true)
                {
                    Console.WriteLine($"In Zeile {zaehler} ist mindestens ein Artikel");
                }

            }
         
          
            


            Console.ReadLine();
        }

        static bool IsUmlaut(string line)
        {
            if (Regex.IsMatch(line, $"[äüö]", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
        static bool IsDer(string line)
        {
            if(Regex.IsMatch(line,$"[der]", RegexOptions .IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsGroßbuchstabe(string line)
        {
            if(Regex.IsMatch(line,$"^[A-Z]", RegexOptions.None))
                {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsFroschkönig(string line)
        {
            if (Regex.IsMatch(line, $"\b[Frosch|Froschkönig]", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsPunkt(string line)
        {
            if (Regex.IsMatch(line, @"[\.]$", RegexOptions.None))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool SharpSEndWord(string line)
        {
            if (Regex.IsMatch(line, @"[ß]\s", RegexOptions.None))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsWhitespace(string line)
        {
            if (Regex.IsMatch(line, @"^\s*$", RegexOptions.None))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsThreeLetters(string line)
        {
            if (Regex.IsMatch(line, @"(?=^\b\w\w\w\b)(?=^\b\D\D\D\b)", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsArtikel(string line)
        {
            if(Regex.IsMatch(line,@"der|die|das", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
