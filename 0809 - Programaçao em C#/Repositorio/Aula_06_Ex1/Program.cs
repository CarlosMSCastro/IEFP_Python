using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saudacao saudacao = new Saudacao();
            saudacao.DizerOla("Carlos");

            CalculadoraSimples calc = new CalculadoraSimples();
            calc.Somar(5, 7);

            ConversorTemperatura conv = new ConversorTemperatura();
            Console.Write("Digite a temperatura em Celsius: ");
            

            if(double.TryParse(Console.ReadLine(),out double c))
            {   
                try
                {
                    double f = conv.CelsiusParaFahrenheit(c);
                    Console.WriteLine("A temperatura em Fahrenheit é: {0}", f);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao converter a temperatura.");
                    Console.WriteLine("Detalhes do erro: " + ex.Message);
                }

            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um numero valido");
            }

            GestorNotas gestor = new GestorNotas();

            Console.WriteLine("Nome do aluno: ");
            string nome = Console.ReadLine();
            if (nome.Length == 0)
            {
                Console.WriteLine("Nome vazio. Por favor insira um nome válido.");
                return;
            }
            double media = gestor.CalculaMedia(12.5, 9.0, 14.0);
            string situacao = gestor.VerificaSituacao(media);

            gestor.MostraResultado(nome, media, situacao);

            Produto p = new Produto("Teclado", 45.99, 8);
            p.MostraDados();

        }
    }
}
