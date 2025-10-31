using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

         
        }
    }
    class Funcionario
    { 
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        public virtual double CalcularSalario()
        {             return SalarioBase;
        }
    }
    class Vendedor : Funcionario
    {
        public double Comissao { get; set; }
        public override double CalcularSalario()
        {
            return SalarioBase + Comissao;
        }
    }
}
