using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter N Number: ");
            int n = int.Parse(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                int x = i + 1;
                Console.Write("Please Enter Array " + x + " Number: ");
                ar[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Your Array Input Is:");
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                Console.Write(ar[i] + "\t");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\t\tMin\t\tMax\t\tAverage");
            int min = ar[0];
            int max = min;
            int avg = 0;
            for (int i = 0; i < n; i++)
            {
                if (min > ar[i])
                {
                    min = ar[i];
                }
                if (max < ar[i])
                {
                    max = ar[i];
                }
                avg += ar[i];
            }
            Console.WriteLine("\t\t" + min + "\t\t" + max + "\t\t" + (avg / n) + "");
            Console.ReadKey();
        }
    }
}
