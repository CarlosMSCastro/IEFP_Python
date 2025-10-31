using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(20, 20);
            Console.WriteLine(r.GetArea());

            Rectangle r2 = new Rectangle(20);
            Console.WriteLine(r2.GetArea());

            Rectangle2 r3 = new Rectangle2();
            r3.Lenght = -10;
            Console.WriteLine(r3.Lenght);
            r3.Lenght = 10;
            Console.WriteLine(r3.Lenght);
        }
    }
    class Rectangle2
    {
        private double length;
        
        public double Lenght
        {
            get {  return length; }
            set
            {
                if (value > 0.0)
                    length = value;
                else
                    length = 1;
            }
        }
    }
    class Rectangle
    {
        private double width;
        private double lenght;

        public Rectangle(double l)
        {
            width = l/2;
            lenght = l;
        }
        public Rectangle(double w, double l)
        {
            width = w;
            lenght = l;
        }
        public double GetArea()
        {
            return width * lenght;
        }
    }
}   

    
