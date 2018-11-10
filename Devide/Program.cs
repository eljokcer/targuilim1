using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program print all the numbers between 2 to 10 that divided by your number\nGive a number!");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nThe numbers:");
            for (int i = 2; i <= 10; i++)
            {
                if (n % i == 0)
                    Console.Write(i + ", ");
            }
            Console.WriteLine("\b\b "); 
        }
    }
}
