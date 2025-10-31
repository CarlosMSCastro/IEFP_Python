using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1, r2;
            r1 = new Rectangle(10, 20);
            r2 = r1;
            r2.lenght = 30;
            Console.WriteLine(r1.lenght);
        }
    }
    class Rectangle
    {
        public double lenght;
        public double width;

        public Rectangle(double l, double w)
        {
            lenght = l;
            width = w;
        }

    }
}
