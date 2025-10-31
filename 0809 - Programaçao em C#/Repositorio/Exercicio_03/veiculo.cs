using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }


        public Veiculo(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }


        public abstract void ExibirInformacoes();


        public virtual double CalcularImposto()
        {
            return 100.0;
        }
        public virtual void ExibirResumo()
        {
            Console.WriteLine($"{Marca} {Modelo} ({Ano})");
        }

    }

}
