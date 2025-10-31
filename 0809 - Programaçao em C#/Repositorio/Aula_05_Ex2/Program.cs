using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Changed += r_Changed;
            r.Lenght = 10;
        }
        static void r_Changed(object sender, EventArgs e)
        {
            Rectangle r = (Rectangle)sender;
            Console.WriteLine("Rectangle changed{0}", r.Lenght);
        }
    }
    class Rectangle
    {
        public event EventHandler Changed;
        private double lenght;
        public double Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                lenght = value;
                Changed(this, EventArgs.Empty);
            }
        }        
    }
}
