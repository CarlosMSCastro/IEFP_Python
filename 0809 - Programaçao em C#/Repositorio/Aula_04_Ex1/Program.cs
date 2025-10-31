using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            //                 0   1   2   3   4
            string[] nomes = {"Ana", "Bia", "Carlos", "Daniel", "Elisa" };
            int[] array2 = new int[10];
            int[,] arraybidimensional = { { 1, 2 }, { 3, 4 } };
            int[,] array3D = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };


            Console.WriteLine(numbers[2]);
            Console.WriteLine(nomes[3]);
            Console.WriteLine($"A array numbers tem {numbers.Length} elementos e a array nomes tem {nomes.Length}");
            Console.WriteLine($"A array numbers tem {array2.Rank} dimensões");
        }



        }
    }

