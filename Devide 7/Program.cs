using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devide_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine("Boom");
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            }

        }
    }
}
