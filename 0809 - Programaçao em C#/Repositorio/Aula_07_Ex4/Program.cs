using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula_07_Ex4
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

            string caminho = @"C:\Users\Slyther1n\Desktop\iefp_formacao\0809 - Programaçao em C#\temp";
            if(Directory.Exists(caminho))
            {
                //Carregar todos os ficheiros do diretorio com o caminho completo do ficheiro.
                string[] ficheiros = Directory.GetFiles(caminho);
                Console.WriteLine("Ficheiros no diretório " + caminho + ":");
                foreach(string f in ficheiros)
                {
                    //Console.WriteLine(f);

                    //Apenas o nome do ficheiro
                    Console.WriteLine(Path.GetFileName(f));
                    //Nome do diretorio
                    Console.WriteLine(Path.GetDirectoryName(f));
                    Console.WriteLine(Path.Combine(Path.GetDirectoryName(f), "Relatório", "Gestão"));

                }
            }
        }
    }
}
