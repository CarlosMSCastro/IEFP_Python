using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_Ex01
{
    class GestorNotas
    {
        public double CalculaMedia(double n1, double n2, double n3)
        {
            return (n1+n2+n3) / 3;
        }
        public string VerificaSituacao(double media)
        {
            if (media >= 10)
                return "Aprovado";
            else
                return "Reprovado";
        }
        public void MostraResultado(string nome, double media, string situacao)
        {
            Console.WriteLine($"Aluno: {nome}");
            Console.WriteLine($"Média: {media:F1}");
            Console.WriteLine($"Situação: {situacao}");
        }
    }
}
