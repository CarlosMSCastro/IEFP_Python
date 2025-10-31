using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula_07_Ex3
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

            string origem = @"C:\Users\Slyther1n\Desktop\iefp_formacao\0809 - Programaçao em C#\temp\dados.txt";
            string destino = @"C:\Users\Slyther1n\Desktop\iefp_formacao\0809 - Programaçao em C#\temp\dados_backup.txt";

            if(File.Exists(destino))
            {
                Console.Write("O ficheiro de destino já existe. Deseja substitui-lo? (s/n): ");
                string resposta = Console.ReadLine().ToLower();

                if(resposta != "s")
                {
                    Console.WriteLine("Operação cancelada.");
                    return;
                }
            }
            File.Copy(origem, destino, true );
            Console.WriteLine("Ficheiro copiado com sucesso.");
        }
    }
}
