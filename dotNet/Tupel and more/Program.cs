namespace Tupel_and_more
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aufgabe1();
            Aufgabe2();



        }
        public static void TupelBilden<T>( T[] array)
        {
            (T, T)[] collection = new(T,T)[array.Length];

            if (array.Length % 2 == 0)
            {
                for (int i = 1; i < array.Length; i += 2)
                {
                    var tupel = (array[i - 1], array[i]);
                    collection[i] = tupel;
                    Console.WriteLine(tupel);
                }
            }
            else
            {
                array.SkipLast(1);
            }
        }
        public static void TupelBilden2<T,K>(T[] arr, K[] arr2)
        {
            (T, K)[] collection;
            if (arr.Length < arr2.Length)
            {
                 collection = new (T, K)[arr.Length];
            }
            else
            {
                collection = new (T, K)[arr2.Length];
            }
            for (int i = 0; i < arr.Length; i++)
                {
                    var tupel = (arr[i], arr2[i]);
                collection[i] = tupel;
                Console.WriteLine(tupel);
                }
          
        }
        static void Aufgabe1()
        {
            int[] arr = { 9, 42, 60, 33, 38, 7, 7, 11 };
            TupelBilden(arr);
        }
        static void Aufgabe2()
        {
            int[] arr = { 21, 65, 6, 1, 14, 58, 56, 38, 18, 2 };
            int[] arr2 = { 95, 1, 86, 32, 66, 27, 67, 10, 54, 55 };
            TupelBilden2(arr, arr2);
        }
        
    }

}
