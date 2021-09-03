using System;

namespace reverse1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Console.WriteLine();
            for (int i = (n.Length-1); i >=0 ; i--)
            {
                Console.Write(n.Substring(i, 1));
            }
            
        }
    }
}
