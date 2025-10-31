using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07_Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File : Métodos estáticos para manipular ficheiiros (ler, criar, escrever)
            //FileInfo : Métodos de instância para manipular ficheiros
            //StreamReader : Ler ficheiros de texto linha a linha
            //StreamWrite : Escrever texto em ficheiros
            //Directory : Métodos estáticos para manipular dirétorios
            //DirectoryInfo : Métodos de Instancia para manipular diretorios

            Console.Write("Nome: ");
            string nome=Console.ReadLine();
            Console.Write("Idade: ");
            string idade = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Slyther1n\Desktop\iefp_formacao\0809 - Programaçao em C#\temp\dados.txt", true))
            {
                sw.WriteLine("\nNome: " + nome);
                sw.WriteLine("Idade: " + idade);
            }

            Console.WriteLine("\nInformação gravada com sucesso!");
        }
    }
}
