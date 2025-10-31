using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aula_08_Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cria a estrutura
            //Cria o ficheiro inventario.txt com 6 artigos mostrá-los formatados no ecrã.
            Console.OutputEncoding = Encoding.UTF8;
            var cultureInfo= Thread.CurrentThread.CurrentCulture;
            var numberFormat = CultureInfo.CurrentCulture.NumberFormat;
            string basePath = @"C:\Users\Slyther1n\Desktop\iefp_formacao\0809 - Programaçao em C#\temp";
            string[] subpastas = { "Artigos", "Clientes", "Vendas" };
            if (Directory.Exists(basePath)== false)
            {
                Directory.CreateDirectory(basePath);
            }
            foreach (string subpasta in subpastas)
            {
                string fullPath = Path.Combine(basePath, subpasta);
                if (Directory.Exists (fullPath) == false)
                {
                    Directory.CreateDirectory (fullPath);
                }
            }
            string[] artigos =
            {
                "Arroz;10;1.49;Mercearia",
                "Massa;15;0.99;Mercearia",
                "Leite;30;0.89;Laticinios",
                "Ovos;12;2.49;Frescos",
                "Maças;25;1.89;Fruta",
                "Pão;20;1.10;Padaria"
            };
            string ficheiro = Path.Combine(basePath, "Artigos", "Inventario.txt");
            File.WriteAllLines(ficheiro, artigos);
            Console.WriteLine("Inventário criado:\n");
            foreach (string linha in artigos)
            {
                string[] campos = linha.Split(';');
                Console.WriteLine($"{campos[0],-10} | Stock: {campos[1],4} | Preço: {campos[2],6} {numberFormat.CurrencySymbol} | Categoria: {campos[3]}");
            }
        }
    }
}
