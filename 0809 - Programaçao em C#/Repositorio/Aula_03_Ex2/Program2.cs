using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            if (x > y)
            {
                Console.WriteLine("X é maior que Y");
                Console.WriteLine($"x: {x}, y: {y}");
            }
            else
            {
                Console.WriteLine("X é menor que Y");
                Console.WriteLine($"x: {x}, y: {y}");
            }

        }
    }
}
