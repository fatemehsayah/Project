using System;

namespace indexcheker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
              
            }
            int index = int.Parse(Console.ReadLine());
            int x = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == index)
                {

                    x = 1;
                }
                
            }
            if (x==1)
            {
                Console.WriteLine("index");
            }
            else
            {
                Console.WriteLine("no index");
            }
            Console.ReadKey();
        }
    }
}
