
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Camiao : Veiculo
    {
        public double CapacidadeCarga { get; set; }

        public Camiao(string marca, string modelo, int ano, double capacidadeCarga)
            : base(marca, modelo, ano)
        {
            CapacidadeCarga = capacidadeCarga;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Camião: {Marca} {Modelo}, Ano: {Ano}, Capacidade de Carga: {CapacidadeCarga}t");
        }

        public override double CalcularImposto()
        {
            return base.CalcularImposto() + 100;
        }
    }
}
