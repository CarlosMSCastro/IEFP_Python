using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Autocarro : Veiculo
    {
        public int NumeroPassageiros { get; set; }

        public Autocarro(string marca, string modelo, int ano, int numeroPassageiros)
            : base(marca, modelo, ano)
        {
            NumeroPassageiros = numeroPassageiros;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Autocarro: {Marca} {Modelo}, Ano: {Ano}, Passageiros: {NumeroPassageiros}");
        }

        public override double CalcularImposto()
        {
            return base.CalcularImposto() + 80;
        }

        public override void ExibirResumo()
        {
            Console.WriteLine($"Autocarro {Marca} ({NumeroPassageiros} passageiros)");
        }
    }
}
