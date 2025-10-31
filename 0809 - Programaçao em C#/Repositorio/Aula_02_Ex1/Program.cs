using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Digite o seu primeiro nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o seu apelido: ");
            var apelido = Console.ReadLine();
            Console.WriteLine("Digite a sua idade: ");
            var idade = Console.ReadLine();
            Console.WriteLine("Digite a cidade onde vive: ");
            var cidade = Console.ReadLine();
            Console.WriteLine("Digite o seu hobby favorito: ");
            var hobby = Console.ReadLine();
            var nome_completo = nome + " " + apelido;
            //imprimir as variaveis na consola
            Console.WriteLine($"---Ficha pessoal---\nNome Completo:{nome_completo}\nIdade: {idade}\nCidade :{cidade}\nHobby Favorito: {hobby}\n-------------\nBem vindo(a) {nome_completo}");

        }
    }
}
