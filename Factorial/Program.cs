using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1, i = 1;
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            while (i<=n)
            {
                sum *= i++; 
            }
            Console.WriteLine(sum);
        }
    }
}
