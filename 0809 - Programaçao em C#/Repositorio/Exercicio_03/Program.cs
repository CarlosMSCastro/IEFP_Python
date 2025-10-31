using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Veiculo> veiculos = new List<Veiculo>();

            veiculos.Add(new Carro("Tesla", "Model 3", 2023, 4));
            veiculos.Add(new Carro("Audi", "A4", 2020, 4));
            veiculos.Add(new Carro("Fiat", "Panda", 2018, 5));
            veiculos.Add(new Carro("Mercedes", "C200", 2021, 4));
            veiculos.Add(new Mota("Yamaha", "MT-09", 2019, 847));
            veiculos.Add(new Mota("Honda", "CB650R", 2022, 649));
            veiculos.Add(new Mota("Ducati", "Monster", 2020, 937));
            veiculos.Add(new Camiao("Volvo", "FH16", 2012, 25.0));
            veiculos.Add(new Camiao("Scania", "R450", 2019, 30.5));
            veiculos.Add(new Camiao("MAN", "TGX", 2017, 22.0));

            foreach (Veiculo v in veiculos)
            {
                v.ExibirResumo();;
            }

            Console.ReadKey();
        }
    }
}