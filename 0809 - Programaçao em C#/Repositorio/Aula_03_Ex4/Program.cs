using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13OutubroTrabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo à calculadora do IMC\n");

            bool continuar = true;

            while (continuar)
            {
                double peso;
                while (true)
                {
                    Console.Write("Insira o seu peso : ");
                    if (double.TryParse(Console.ReadLine(), out peso))
                        break;
                    else
                        Console.WriteLine("Número inválido\n");
                }
                double altura;
                while (true)
                {
                    Console.Write("Indique a sua altura: ");
                    if (double.TryParse(Console.ReadLine(), out altura))
                        break;
                    else
                        Console.WriteLine("Valor inválido\n");
                }

                double imc = peso / (altura * altura);
                Console.WriteLine($"\nO seu IMC é: {imc}");

                if (imc < 18.5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Classificação: Abaixo do peso");
                }
                else if (imc < 24.9)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Classificação: Peso normal");
                }
                else if (imc < 29.9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Classificação:Excesso de Peso");
                }
                else if (imc < 34.9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Classificação: Obesidade Grau I");
                }
                else if (imc < 39.9)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Classificação: Obesidade Grau II");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Classificação:Obesidade Grau III");
                }
                Console.ResetColor();
                Console.WriteLine("\nCalcular outro IMC? (S/N)");
                string resposta = Console.ReadLine();
                if (resposta != "S")
                {
                    continuar = false;
                    Console.WriteLine("\nAté á próxima!");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}