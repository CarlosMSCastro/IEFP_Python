using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Concessionario loja = new Concessionario();
            Carro[] stockInicial = new Carro[]
            {
            new Carro("Volvo", "XC40", 2020, 26500),
            new Carro("Tesla", "Model 3", 2023, 33250),
            new Carro("Porsche", "Taycan", 2021, 63000)
            };

            foreach (Carro c in stockInicial)
            {
                loja.AdicionarCarro(c);
            }
            bool ativo = true;
            double[] vendas = new double[10];
            int totalVendas = 0;

            while (ativo)
            {
                Console.WriteLine("\n=== CONCESSIONÁRIO AUTO ===");
                Console.WriteLine("1. Adicionar carro");
                Console.WriteLine("2. Listar carros disponíveis");
                Console.WriteLine("3. Vender carro");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarCarroMenu(loja);
                        break;
                    case "2":
                        loja.ListarCarrosDisponiveis();
                        break;
                    case "3":
                        Console.Write("Modelo do carro a vender: ");
                        string modelo = Console.ReadLine();
                        Carro carroAVender = loja.ObterCarroPorModelo(modelo);
                        if (carroAVender != null)
                        {
                            loja.VenderCarro(modelo);
                            if (totalVendas < 10)
                            {
                                vendas[totalVendas] = carroAVender.Preco;
                                totalVendas++;
                            }

                            double totalAcumulado = 0;
                            foreach (double v in vendas)
                            {
                                totalAcumulado += v;
                            }

                            Console.WriteLine($"Total acumulado de vendas: {totalAcumulado} Euros");
                        }
                        else
                        {
                            Console.WriteLine("Carro não encontrado.");
                        }
                            break;
                    case "4":
                        ativo = false;
                        Console.WriteLine("A Sair...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
        static void AdicionarCarroMenu(Concessionario loja)
        {
            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Carro novoCarro = new Carro(marca, modelo, ano, preco);
            loja.AdicionarCarro(novoCarro);

            Console.WriteLine("Carro adicionado com sucesso!");
        }
    }
    class Carro
    {
        public Carro(string marca, string modelo, int ano, double preco)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Preco = preco;
            Vendido = false;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
        public bool Vendido { get; set; }
        public void ExibirDetalhes()
        {
            string estado = "Disponível";
            if (Vendido)
            {
                estado = "Vendido";
            }
            Console.WriteLine($"{Marca} {Modelo} ({Ano}) - ({Preco} Euros) - {estado}");
        }
        public void MarcarComoVendido()
        {
            Vendido = true;
        }
    }
    class Concessionario
    {
        private List<Carro> carros = new List<Carro>();
        public void AdicionarCarro(Carro c)
        {
            carros.Add(c);
        }
        public void ListarCarrosDisponiveis()
        {
            Console.WriteLine("\n--- Carros disponíveis ---");
            foreach (Carro c in carros)
            {
                if (!c.Vendido)
                    c.ExibirDetalhes();
            }
        }
        public void VenderCarro(string modelo)
        {
            Carro carroAVender = null;

            foreach (Carro c in carros)
            {
                if (c.Modelo.ToLower() == modelo.ToLower())
                {
                    carroAVender = c;
                    break;
                }
            }

            if (carroAVender != null)
            {
                carroAVender.MarcarComoVendido();
                carros.Remove(carroAVender);
                Console.WriteLine($"{modelo} foi removido do stock.");
            }
            else
            {
                Console.WriteLine($"Não foi encontrado nenhum carro com o modelo '{modelo}'.");
            }
        }
        public Carro ObterCarroPorModelo(string modelo)
        {
            foreach (Carro c in carros)
            {
                if (c.Modelo.ToLower() == modelo.ToLower())
                {
                    return c;
                }
            }
            return null;
        }
    }
}