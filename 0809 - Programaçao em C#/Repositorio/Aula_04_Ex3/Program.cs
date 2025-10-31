using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = {"Ana", "Bia", "Carlos", "Daniel", "Rafaela", "Gui" };
            foreach (var nome in nomes)
            {
                Console.WriteLine("O nome é " + nome.ToUpper());
                Console.WriteLine("A sua inicial é" + nome[0]);
                Console.WriteLine("Outra forma de obter sua inicial é" + nome.Substring(0,1));
                Console.WriteLine("A ultima letra do seu nome é" + nome[nome.Length -1]);
                Console.WriteLine("Outra forma de obter sua ultma letra é" + nome.Substring(-1,1));
            }
        }
    }
}
