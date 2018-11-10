using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Done
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to finish type \"done\"");
            string input = Console.ReadLine();
            int counter = 0, divider = 2;
            double sum = 0;
            for (; input != "done"; divider++)
            {
                int num = int.Parse(input);
                sum += num;
                counter++;
                Console.WriteLine("Enter a number to finish type \"done\"");
                input = Console.ReadLine();

            }
            Console.WriteLine("avg: {0}", Math.Round(sum / counter, 3));
        }
    }
}
