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
            Console.WriteLine("Indique um operador (+,-,*,/):");
            char operador = Console.ReadKey().KeyChar;

            Console.WriteLine("\nIndique o primeiro número:");
            //double num1 = double.Parse(Console.ReadLine());
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Número inválido.");
                return;
            }
            double resultado;

            Console.WriteLine("Indique o segundo número:");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    return;
            }
            Console.WriteLine($"\nO resultado de {num1} {operador}{num2} é: {resultado}");
        }
    }
