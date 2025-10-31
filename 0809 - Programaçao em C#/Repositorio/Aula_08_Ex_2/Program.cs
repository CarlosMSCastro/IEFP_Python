using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Aula_08_Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define o ficheiro a ler
            string ficheiro = @"C:\Users\Slyther1n\Desktop\iefp_formacao\0809 - Programaçao em C#\temp\Artigos\Inventario.txt";
            //Lê todas as linhas do ficheiro para uma array de strings
            string[] linhas = File.ReadAllLines(ficheiro, Encoding.UTF8);
            //Pede ao utilizador para inserir uma categoria
            Console.Write("\nIntroduza uma categoria: ");
            //Carrega a categoria introduzida na consola para uma variavel
            string categoria = Console.ReadLine();

            Console.WriteLine($"\nArtigos da categoria {categoria}:\n");
            //Percorre todas as linhas do ficheiro
            foreach ( string line in linhas)
            {
                //Separa os campos da linha
                string[] c = line.Split(';');
                //Verifica se a categoria é igual á introduzida pelo utilizador
                //Ignorado maiúsuclas e minúsculas
                if (c[3].Equals(categoria, StringComparison.OrdinalIgnoreCase))
                {
                    //Converte o preço para double
                    double preco = double.Parse(c[2]);
                    Console.WriteLine($"{c[0]} - {preco.ToString("C2")}");
                }
            }
            double totalStock = 0, totalValor = 0;
            string artigoMaisCaro = "", artigoMaisBarato = "";
            double MaxPreco=double.MinValue, MinPreco=double.MaxValue;
            //Percorre todas as linhas do ficheiro
            foreach (string linha in linhas)
            {
                //Separa os campos da linha
                string[] c = linha.Split(';');
                //Converte o preço e o stock
                double preco = double.Parse(c[2]);
                //Converte o stock para int
                int stock = int.Parse(c[1]);
                //Acumula o stock e o valor total
                totalStock += stock;
                totalValor += preco * stock;
                //Verifica se é o artigo mais caro ou mais barato
                if (preco > MaxPreco)
                {
                    MaxPreco = preco;
                    artigoMaisCaro = c[0];
                }
                if (preco < MinPreco)
                {
                    MinPreco = preco;
                    artigoMaisBarato = c[0];
                }
            }
            Console.WriteLine($"\nValor total em Stock: {totalStock:F2} €");
            Console.WriteLine($"Quantidade total: {totalStock} €");
            Console.WriteLine($"Artigo mais caro: {artigoMaisCaro} - {MaxPreco.ToString("C2")}");
            Console.WriteLine($"Artigo mais caro: {artigoMaisBarato} - {MinPreco.ToString("C2")}");
        }

    }
}
