using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numAlunos;

            while (true)
            {
                Console.Write("Escreva o número de alunos: ");
                if (int.TryParse(Console.ReadLine(), out numAlunos) && numAlunos > 0)
                    break;
                else
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro positivo.");
            }

            double[] notas = new double[numAlunos];

            Console.WriteLine("\n=== Introdução das Notas dos Alunos ===");

            for (int i = 0; i < numAlunos; i++)
            {
                double nota;
                while (true)
                {
                    Console.Write($"Introduza a nota do {i + 1}º aluno (0 a 20): ");
                    if (double.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 20)
                        break;
                    else
                        Console.WriteLine("Nota inválida! Insira um número entre 0 e 20.");
                }
                notas[i] = nota;
            }

            double soma = 0;
            foreach (double nota in notas)
            {
                soma += nota;
            }

            double media = soma / notas.Length;
            Console.WriteLine($"\nMédia das notas: {media:F2}");

            int aprovados = 0;
            foreach (double nota in notas)
            {
                if (nota >= 10)
                    aprovados++;
            }

            Console.WriteLine($"Número de alunos aprovados: {aprovados}");

            Console.WriteLine("\nNotas acima da média:");
            int acimadamedia = 0;

            foreach (double nota in notas)
            {
                if (nota >= media)
                {
                    Console.WriteLine(nota);
                    acimadamedia++;
                }
            }

            Console.ReadKey();
        }
    }
}
