using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Mota : Veiculo
    {
        public int Cilindrada { get; set; }

        public Mota(string marca, string modelo, int ano, int cilindrada)
            : base(marca, modelo, ano)
        {
            Cilindrada = cilindrada;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Mota: {Marca} {Modelo}, Ano: {Ano}, Cilindrada: {Cilindrada}cc");
        }

        public override double CalcularImposto()
        {
            return base.CalcularImposto() + 20;
        }
    }
}
