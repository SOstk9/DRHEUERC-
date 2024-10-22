using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //neue Instanz anlegen
            SimpleDate date = new SimpleDate();

            try
            {
                date.Year = -2;
                date.Month = 10;
                date.Day = 10;
            }
            catch (DayOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (MonthOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (YearOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Neu eingeben:");
                date.Year = int.Parse(Console.ReadLine());
            }

            Console.ReadLine();
        
        }
    }
}
