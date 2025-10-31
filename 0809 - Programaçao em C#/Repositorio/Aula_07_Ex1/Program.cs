using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula_07_Ex01
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

            bool ExisteFicheiro = File.Exists(@"c:\Temp\teste.txt");
            if (ExisteFicheiro)
            {
                File.Delete(@"c:\Temp\teste.txt");
                //File.Create(@"c:\Temp\teste.txt");
                File.WriteAllText(@"c:\Temp\teste.txt", "Olá Mundo!");
                File.AppendAllText(@"c:\Temp\teste.txt", Environment.NewLine + "Olá Mundo! 2");
            }
            else
            {
                File.WriteAllText(@"c:\Temp\teste.txt", "Olá Mundo!");
                File.AppendAllText(@"c:\Temp\teste.txt", Environment.NewLine + "Olá Mundo! 2");
            }
        }
    }
}
