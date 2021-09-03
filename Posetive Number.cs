using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosetiveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter N Number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
			Console.Write("Posetive Number is: ");
            for (int i = 1; i < n; i++)
            {
				if(i%2 != 0)
				{
					Console.Write( i + "\t");
				}
            }
            Console.ReadKey();
        }
    }
}
