using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_Ex01
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double CalculaValorStock()
        {
            return Preco * Quantidade;
        }

        public void MostraDados()
        {
            Console.OutputEncoding =  System.Text.Encoding.UTF8;
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine($"Valor total em stock: {CalculaValorStock():c}");
        }
    }

}
