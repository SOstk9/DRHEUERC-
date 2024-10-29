namespace DelegatesArrayMinMax

{
    delegate bool VergleichsHandler(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[10];
            VergleichsHandler groeßer = istGrößer;
            VergleichsHandler kleiner = istKleiner;
            
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1,10);
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine(GetLimit(arr, groeßer));
            Console.WriteLine("---------------------------");
            Console.WriteLine(GetLimit(arr, kleiner));

            
        }

        static int GetLimit(int[] array, VergleichsHandler limit)
        {
            int temp = 0;
           int min = array[0];

           for (int i = 0; i < array.Length; i++)
            {
                if(limit(min, array[i]))
                {
                  
                }
                else
                {
                    min = array[i];
                    temp = i;
                }
            }
            return temp;
        }

        static bool istKleiner(int a, int b)
        {
            return a < b;
        }

        static bool istGrößer(int a, int b)
        {
            return a > b;
        }
    }
}
