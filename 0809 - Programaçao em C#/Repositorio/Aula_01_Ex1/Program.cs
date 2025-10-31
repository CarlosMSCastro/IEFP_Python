using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olá_Mundo
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            OlaMundo();
            OlaCidade();
            OlaCasa();
            int a = 5;
            int A = 10;
        }
        static void OlaMundo()
        {
            Console.WriteLine("Olá, Mundo!");
            Console.ReadKey();
        }
        static void OlaCidade()
        {
            Console.WriteLine("Olá, Cidade!");
            Console.ReadKey();
        }
    }
}
