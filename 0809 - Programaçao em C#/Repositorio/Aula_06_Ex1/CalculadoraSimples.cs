using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_Ex01
{
    class CalculadoraSimples
    {
        public double Somar(double a, double b)
        {
            return a + b;
        }

        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: divisão por zero!");
                return 0;
            }
            return a / b;
        }
    }
}