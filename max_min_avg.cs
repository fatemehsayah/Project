using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr[0] = int.Parse(Console.ReadLine());
            int max = arr[0];
            int min = arr[0];
            int avg = arr[0];
            for (int i = 1; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (max<arr[i])
                {
                    max = arr[i];
                }
                if (min>arr[i])
                {
                    min= arr[i];
                }
                avg += arr[i];
                
            }
            Console.WriteLine("max=" + max + "\tmin=" + min + "\tavg=" + avg / n);
            Console.ReadKey();

        }
    }
}
