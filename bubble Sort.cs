using System;

namespace te
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
            int temp;
            int flag = 1;
            while (flag == 1)
            {
                flag = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    if (ar[i] > ar[i + 1])
                    {
                        temp = ar[i];
                        ar[i] = ar[i + 1];
                        ar[i + 1] = temp;
                        flag = 1;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(ar[i] + "\t");
            }
            Console.ReadKey();
            }
        }
    }

