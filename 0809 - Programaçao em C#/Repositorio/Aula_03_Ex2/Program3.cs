using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota obtida: ");
            int nota = int.Parse(Console.ReadLine();
            if (nota < 9)Console.Write("Reprovado");
            else if (nota < 13)Console.Write("Suficiente");
            else if (nota < 17)Console.Write("Bom");
            else Console.Write("Excelente");


        }
    }
}
