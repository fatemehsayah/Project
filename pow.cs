using System;

namespace pow3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
              
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+"\t\t");

            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Double x = Math.Pow( arr[i],3);
                Console.Write(x +"\t\t");
            }
            Console.ReadKey();
        }
    }
}
