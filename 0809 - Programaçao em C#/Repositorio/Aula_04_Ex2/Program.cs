using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5, 8, 2, 10, 3 };
            int soma = 0;
            foreach(int numero in numeros)
            {
                soma += numero;
            }
            Console.WriteLine($"A soma dos números é: {soma}");
        }
    }
}
