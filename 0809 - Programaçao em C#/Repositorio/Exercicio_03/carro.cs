using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }

        public Carro(string marca, string modelo, int ano, int numeroPortas)
            : base(marca, modelo, ano)
        {
            NumeroPortas = numeroPortas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}, Portas: {NumeroPortas}");
        }

        public override double CalcularImposto()
        {
            return base.CalcularImposto() + 50;
        }
    }
}