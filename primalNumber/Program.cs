using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if the number is prime");
            int num = int.Parse(Console.ReadLine());
            int counter = 2;
            bool isPrime = true;
            while (counter <= (0.5 * num))
            {
                if (num % counter == 0)
                {
                    Console.WriteLine("The number is not prime");
                    break;
                }
                counter++;
            }

            if (isPrime == true)
            {
                Console.WriteLine("The number is prime");
            }
        }
    }
}
